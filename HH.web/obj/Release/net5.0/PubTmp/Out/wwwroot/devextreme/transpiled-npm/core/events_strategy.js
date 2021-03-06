"use strict";

exports.EventsStrategy = void 0;

var _callbacks = _interopRequireDefault(require("./utils/callbacks"));

var _iterator = require("./utils/iterator");

var _type = require("./utils/type");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var EventsStrategy = /*#__PURE__*/function () {
  function EventsStrategy(owner) {
    _classCallCheck(this, EventsStrategy);

    this._events = {};
    this._owner = owner;
  }

  _createClass(EventsStrategy, [{
    key: "hasEvent",
    value: function hasEvent(eventName) {
      var callbacks = this._events[eventName];
      return callbacks ? callbacks.has() : false;
    }
  }, {
    key: "fireEvent",
    value: function fireEvent(eventName, eventArgs) {
      var callbacks = this._events[eventName];

      if (callbacks) {
        callbacks.fireWith(this._owner, eventArgs);
      }

      return this._owner;
    }
  }, {
    key: "on",
    value: function on(eventName, eventHandler) {
      var _this = this;

      if ((0, _type.isPlainObject)(eventName)) {
        (0, _iterator.each)(eventName, function (e, h) {
          _this.on(e, h);
        });
      } else {
        var callbacks = this._events[eventName];

        if (!callbacks) {
          callbacks = (0, _callbacks.default)();
          this._events[eventName] = callbacks;
        }

        var addFn = callbacks.originalAdd || callbacks.add;
        addFn.call(callbacks, eventHandler);
      }
    }
  }, {
    key: "off",
    value: function off(eventName, eventHandler) {
      var callbacks = this._events[eventName];

      if (callbacks) {
        if ((0, _type.isFunction)(eventHandler)) {
          callbacks.remove(eventHandler);
        } else {
          callbacks.empty();
        }
      }
    }
  }, {
    key: "dispose",
    value: function dispose() {
      (0, _iterator.each)(this._events, function (eventName, event) {
        event.empty();
      });
    }
  }], [{
    key: "create",
    value: function create(owner, strategy) {
      if (strategy) {
        return (0, _type.isFunction)(strategy) ? strategy(owner) : strategy;
      } else {
        return new EventsStrategy(owner);
      }
    }
  }]);

  return EventsStrategy;
}();

exports.EventsStrategy = EventsStrategy;