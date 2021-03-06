"use strict";

exports.PostponedOperations = void 0;

var _deferred = require("./utils/deferred");

var _type = require("./utils/type");

function _toConsumableArray(arr) { return _arrayWithoutHoles(arr) || _iterableToArray(arr) || _unsupportedIterableToArray(arr) || _nonIterableSpread(); }

function _nonIterableSpread() { throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _unsupportedIterableToArray(o, minLen) { if (!o) return; if (typeof o === "string") return _arrayLikeToArray(o, minLen); var n = Object.prototype.toString.call(o).slice(8, -1); if (n === "Object" && o.constructor) n = o.constructor.name; if (n === "Map" || n === "Set") return Array.from(o); if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen); }

function _iterableToArray(iter) { if (typeof Symbol !== "undefined" && Symbol.iterator in Object(iter)) return Array.from(iter); }

function _arrayWithoutHoles(arr) { if (Array.isArray(arr)) return _arrayLikeToArray(arr); }

function _arrayLikeToArray(arr, len) { if (len == null || len > arr.length) len = arr.length; for (var i = 0, arr2 = new Array(len); i < len; i++) { arr2[i] = arr[i]; } return arr2; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var PostponedOperations = /*#__PURE__*/function () {
  function PostponedOperations() {
    _classCallCheck(this, PostponedOperations);

    this._postponedOperations = {};
  }

  _createClass(PostponedOperations, [{
    key: "add",
    value: function add(key, fn, postponedPromise) {
      if (key in this._postponedOperations) {
        postponedPromise && this._postponedOperations[key].promises.push(postponedPromise);
      } else {
        var completePromise = new _deferred.Deferred();
        this._postponedOperations[key] = {
          fn: fn,
          completePromise: completePromise,
          promises: postponedPromise ? [postponedPromise] : []
        };
      }

      return this._postponedOperations[key].completePromise.promise();
    }
  }, {
    key: "callPostponedOperations",
    value: function callPostponedOperations() {
      for (var key in this._postponedOperations) {
        var operation = this._postponedOperations[key];

        if ((0, _type.isDefined)(operation)) {
          if (operation.promises && operation.promises.length) {
            _deferred.when.apply(void 0, _toConsumableArray(operation.promises)).done(operation.fn).then(operation.completePromise.resolve);
          } else {
            operation.fn().done(operation.completePromise.resolve);
          }
        }
      }

      this._postponedOperations = {};
    }
  }]);

  return PostponedOperations;
}();

exports.PostponedOperations = PostponedOperations;