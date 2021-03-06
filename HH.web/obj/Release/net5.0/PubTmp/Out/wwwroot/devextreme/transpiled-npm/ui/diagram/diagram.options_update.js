"use strict";

exports.default = void 0;

var _diagram = _interopRequireDefault(require("./diagram.bar"));

var _diagram2 = require("./diagram.importer");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _typeof(obj) { "@babel/helpers - typeof"; if (typeof Symbol === "function" && typeof Symbol.iterator === "symbol") { _typeof = function _typeof(obj) { return typeof obj; }; } else { _typeof = function _typeof(obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; }; } return _typeof(obj); }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); if (superClass) _setPrototypeOf(subClass, superClass); }

function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf || function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

function _possibleConstructorReturn(self, call) { if (call && (_typeof(call) === "object" || typeof call === "function")) { return call; } return _assertThisInitialized(self); }

function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Date.prototype.toString.call(Reflect.construct(Date, [], function () {})); return true; } catch (e) { return false; } }

function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

var DiagramOptionsUpdateBar = /*#__PURE__*/function (_DiagramBar) {
  _inherits(DiagramOptionsUpdateBar, _DiagramBar);

  var _super = _createSuper(DiagramOptionsUpdateBar);

  function DiagramOptionsUpdateBar(owner) {
    var _this;

    _classCallCheck(this, DiagramOptionsUpdateBar);

    _this = _super.call(this, owner);

    var _getDiagram = (0, _diagram2.getDiagram)(),
        DiagramCommand = _getDiagram.DiagramCommand;

    _this.commandOptions = {};
    _this.commandOptions[DiagramCommand.Fullscreen] = 'fullScreen';

    _this.commandOptions[DiagramCommand.ZoomLevel] = function (value) {
      if (_typeof(this._getOption('zoomLevel')) === 'object') {
        this._setOption('zoomLevel.value', value);
      } else {
        this._setOption('zoomLevel', value);
      }
    };

    _this.commandOptions[DiagramCommand.SwitchAutoZoom] = function (value) {
      var _getDiagram2 = (0, _diagram2.getDiagram)(),
          AutoZoomMode = _getDiagram2.AutoZoomMode;

      switch (value) {
        case AutoZoomMode.FitContent:
          this._setOption('autoZoomMode', 'fitContent');

          break;

        case AutoZoomMode.FitToWidth:
          this._setOption('autoZoomMode', 'fitWidth');

          break;

        case AutoZoomMode.Disabled:
          this._setOption('autoZoomMode', 'disabled');

          break;
      }
    };

    _this.commandOptions[DiagramCommand.ToggleSimpleView] = 'simpleView';
    _this.commandOptions[DiagramCommand.ShowGrid] = 'showGrid';
    _this.commandOptions[DiagramCommand.SnapToGrid] = 'snapToGrid';

    _this.commandOptions[DiagramCommand.GridSize] = function (value) {
      if (_typeof(this._getOption('gridSize')) === 'object') {
        this._setOption('gridSize.value', value);
      } else {
        this._setOption('gridSize', value);
      }
    };

    _this.commandOptions[DiagramCommand.ViewUnits] = 'viewUnits';

    _this.commandOptions[DiagramCommand.PageSize] = function (value) {
      var pageSize = this._getOption('pageSize');

      if (pageSize === undefined || pageSize.width !== value.width || pageSize.height !== value.height) {
        this._setOption('pageSize', value);
      }
    };

    _this.commandOptions[DiagramCommand.PageLandscape] = function (value) {
      this._setOption('pageOrientation', value ? 'landscape' : 'portrait');
    };

    _this.commandOptions[DiagramCommand.ViewUnits] = function (value) {
      var _getDiagram3 = (0, _diagram2.getDiagram)(),
          DiagramUnit = _getDiagram3.DiagramUnit;

      switch (value) {
        case DiagramUnit.In:
          this._setOption('viewUnits', 'in');

          break;

        case DiagramUnit.Cm:
          this._setOption('viewUnits', 'cm');

          break;

        case DiagramUnit.Px:
          this._setOption('viewUnits', 'px');

          break;
      }
    };

    _this.commandOptions[DiagramCommand.PageColor] = 'pageColor';
    _this._updateLock = 0;
    return _this;
  }

  _createClass(DiagramOptionsUpdateBar, [{
    key: "getCommandKeys",
    value: function getCommandKeys() {
      return Object.keys(this.commandOptions).map(function (key) {
        return parseInt(key);
      });
    }
  }, {
    key: "setItemValue",
    value: function setItemValue(key, value) {
      if (this.isUpdateLocked()) return;
      this.beginUpdate();

      try {
        if (typeof this.commandOptions[key] === 'function') {
          this.commandOptions[key].call(this, value);
        } else {
          this._setOption(this.commandOptions[key], value);
        }
      } finally {
        this.endUpdate();
      }
    }
  }, {
    key: "beginUpdate",
    value: function beginUpdate() {
      this._updateLock++;
    }
  }, {
    key: "endUpdate",
    value: function endUpdate() {
      this._updateLock--;
    }
  }, {
    key: "isUpdateLocked",
    value: function isUpdateLocked() {
      return this._updateLock > 0;
    }
  }, {
    key: "_getOption",
    value: function _getOption(name) {
      return this._owner.option(name);
    }
  }, {
    key: "_setOption",
    value: function _setOption(name, value) {
      this._owner.option(name, value);
    }
  }]);

  return DiagramOptionsUpdateBar;
}(_diagram.default);

var _default = DiagramOptionsUpdateBar;
exports.default = _default;
module.exports = exports.default;