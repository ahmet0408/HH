"use strict";

exports.default = void 0;

var _renderer = _interopRequireDefault(require("../../../core/renderer"));

var _button = _interopRequireDefault(require("./button"));

var _button2 = _interopRequireDefault(require("../../button"));

var _extend = require("../../../core/utils/extend");

var _events_engine = _interopRequireDefault(require("../../../events/core/events_engine"));

var _hover = require("../../../events/hover");

var _click = require("../../../events/click");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

function _get(target, property, receiver) { if (typeof Reflect !== "undefined" && Reflect.get) { _get = Reflect.get; } else { _get = function _get(target, property, receiver) { var base = _superPropBase(target, property); if (!base) return; var desc = Object.getOwnPropertyDescriptor(base, property); if (desc.get) { return desc.get.call(receiver); } return desc.value; }; } return _get(target, property, receiver || target); }

function _superPropBase(object, property) { while (!Object.prototype.hasOwnProperty.call(object, property)) { object = _getPrototypeOf(object); if (object === null) break; } return object; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); if (superClass) _setPrototypeOf(subClass, superClass); }

function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf || function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } return _assertThisInitialized(self); }

function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Date.prototype.toString.call(Reflect.construct(Date, [], function () {})); return true; } catch (e) { return false; } }

function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

var CUSTOM_BUTTON_HOVERED_CLASS = 'dx-custom-button-hovered';

var CustomButton = /*#__PURE__*/function (_TextEditorButton) {
  _inherits(CustomButton, _TextEditorButton);

  var _super = _createSuper(CustomButton);

  function CustomButton() {
    _classCallCheck(this, CustomButton);

    return _super.apply(this, arguments);
  }

  _createClass(CustomButton, [{
    key: "_attachEvents",
    value: function _attachEvents(instance, $element) {
      var editor = this.editor;

      _events_engine.default.on($element, _hover.start, function () {
        editor.$element().addClass(CUSTOM_BUTTON_HOVERED_CLASS);
      });

      _events_engine.default.on($element, _hover.end, function () {
        editor.$element().removeClass(CUSTOM_BUTTON_HOVERED_CLASS);
      });

      _events_engine.default.on($element, _click.name, function (e) {
        e.stopPropagation();
      });
    }
  }, {
    key: "_create",
    value: function _create() {
      var editor = this.editor;
      var $element = (0, _renderer.default)('<div>');

      this._addToContainer($element);

      var instance = editor._createComponent($element, _button2.default, (0, _extend.extend)({}, this.options, {
        ignoreParentReadOnly: true,
        disabled: this._isDisabled(),
        integrationOptions: this._prepareIntegrationOptions(editor)
      }));

      return {
        $element: $element,
        instance: instance
      };
    }
  }, {
    key: "_prepareIntegrationOptions",
    value: function _prepareIntegrationOptions(editor) {
      return (0, _extend.extend)({}, editor.option('integrationOptions'), {
        skipTemplates: ['content']
      });
    }
  }, {
    key: "update",
    value: function update() {
      var isUpdated = _get(_getPrototypeOf(CustomButton.prototype), "update", this).call(this);

      if (this.instance) {
        this.instance.option('disabled', this._isDisabled());
      }

      return isUpdated;
    }
  }, {
    key: "_isVisible",
    value: function _isVisible() {
      var editor = this.editor;
      return editor.option('visible');
    }
  }, {
    key: "_isDisabled",
    value: function _isDisabled() {
      var isDefinedByUser = this.options.disabled !== undefined;

      if (isDefinedByUser) {
        return this.instance ? this.instance.option('disabled') : this.options.disabled;
      } else {
        return this.editor.option('readOnly');
      }
    }
  }]);

  return CustomButton;
}(_button.default);

exports.default = CustomButton;
module.exports = exports.default;