"use strict";

exports.default = void 0;

var _class = _interopRequireDefault(require("../core/class"));

var _events_strategy = require("../core/events_strategy");

var _iterator = require("../core/utils/iterator");

var _errors = _interopRequireDefault(require("./errors"));

var _utils = _interopRequireDefault(require("./utils"));

var _data = require("../core/utils/data");

var _store_helper = _interopRequireDefault(require("./store_helper"));

var _deferred = require("../core/utils/deferred");

var _common = require("../core/utils/common");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var abstract = _class.default.abstract;
var queryByOptions = _store_helper.default.queryByOptions;
var storeImpl = {};

var Store = _class.default.inherit({
  ctor: function ctor(options) {
    var that = this;
    options = options || {};
    this._eventsStrategy = new _events_strategy.EventsStrategy(this);
    (0, _iterator.each)(['onLoaded', 'onLoading', 'onInserted', 'onInserting', 'onUpdated', 'onUpdating', 'onPush', 'onRemoved', 'onRemoving', 'onModified', 'onModifying'], function (_, optionName) {
      if (optionName in options) {
        that.on(optionName.slice(2).toLowerCase(), options[optionName]);
      }
    });
    this._key = options.key;
    this._errorHandler = options.errorHandler;
    this._useDefaultSearch = true;
  },
  _customLoadOptions: function _customLoadOptions() {
    return null;
  },
  key: function key() {
    return this._key;
  },
  keyOf: function keyOf(obj) {
    if (!this._keyGetter) {
      this._keyGetter = (0, _data.compileGetter)(this.key());
    }

    return this._keyGetter(obj);
  },
  _requireKey: function _requireKey() {
    if (!this.key()) {
      throw _errors.default.errors.Error('E4005');
    }
  },
  load: function load(options) {
    var that = this;
    options = options || {};

    this._eventsStrategy.fireEvent('loading', [options]);

    return this._withLock(this._loadImpl(options)).done(function (result) {
      that._eventsStrategy.fireEvent('loaded', [result, options]);
    });
  },
  _loadImpl: function _loadImpl(options) {
    return queryByOptions(this.createQuery(options), options).enumerate();
  },
  _withLock: function _withLock(task) {
    var result = new _deferred.Deferred();
    task.done(function () {
      var that = this;
      var args = arguments;

      _utils.default.processRequestResultLock.promise().done(function () {
        result.resolveWith(that, args);
      });
    }).fail(function () {
      result.rejectWith(this, arguments);
    });
    return result;
  },
  createQuery: abstract,
  totalCount: function totalCount(options) {
    return this._totalCountImpl(options);
  },
  _totalCountImpl: function _totalCountImpl(options) {
    return queryByOptions(this.createQuery(options), options, true).count();
  },
  byKey: function byKey(key, extraOptions) {
    return this._addFailHandlers(this._withLock(this._byKeyImpl(key, extraOptions)));
  },
  _byKeyImpl: abstract,
  insert: function insert(values) {
    var that = this;

    that._eventsStrategy.fireEvent('modifying');

    that._eventsStrategy.fireEvent('inserting', [values]);

    return that._addFailHandlers(that._insertImpl(values).done(function (callbackValues, callbackKey) {
      that._eventsStrategy.fireEvent('inserted', [callbackValues, callbackKey]);

      that._eventsStrategy.fireEvent('modified');
    }));
  },
  _insertImpl: abstract,
  update: function update(key, values) {
    var that = this;

    that._eventsStrategy.fireEvent('modifying');

    that._eventsStrategy.fireEvent('updating', [key, values]);

    return that._addFailHandlers(that._updateImpl(key, values).done(function () {
      that._eventsStrategy.fireEvent('updated', [key, values]);

      that._eventsStrategy.fireEvent('modified');
    }));
  },
  _updateImpl: abstract,
  push: function push(changes) {
    this._pushImpl(changes);

    this._eventsStrategy.fireEvent('push', [changes]);
  },
  _pushImpl: _common.noop,
  remove: function remove(key) {
    var that = this;

    that._eventsStrategy.fireEvent('modifying');

    that._eventsStrategy.fireEvent('removing', [key]);

    return that._addFailHandlers(that._removeImpl(key).done(function (callbackKey) {
      that._eventsStrategy.fireEvent('removed', [callbackKey]);

      that._eventsStrategy.fireEvent('modified');
    }));
  },
  _removeImpl: abstract,
  _addFailHandlers: function _addFailHandlers(deferred) {
    return deferred.fail(this._errorHandler).fail(_errors.default._errorHandler);
  },
  on: function on(eventName, eventHandler) {
    this._eventsStrategy.on(eventName, eventHandler);

    return this;
  },
  off: function off(eventName, eventHandler) {
    this._eventsStrategy.off(eventName, eventHandler);

    return this;
  }
});

Store.create = function (alias, options) {
  if (!(alias in storeImpl)) {
    throw _errors.default.errors.Error('E4020', alias);
  }

  return new storeImpl[alias](options);
};

Store.registerClass = function (type, alias) {
  if (alias) {
    storeImpl[alias] = type;
  }

  return type;
};

Store.inherit = function (inheritor) {
  return function (members, alias) {
    var type = inheritor.apply(this, [members]);
    Store.registerClass(type, alias);
    return type;
  };
}(Store.inherit);

var _default = Store;
exports.default = _default;
module.exports = exports.default;