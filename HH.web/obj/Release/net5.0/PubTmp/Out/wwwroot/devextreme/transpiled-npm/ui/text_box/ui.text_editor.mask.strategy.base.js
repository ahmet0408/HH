"use strict";

exports.default = void 0;

var _events_engine = _interopRequireDefault(require("../../events/core/events_engine"));

var _index = require("../../events/utils/index");

var _browser = _interopRequireDefault(require("../../core/utils/browser"));

var _array = require("../../core/utils/array");

var _dom = require("../../core/utils/dom");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var MASK_EVENT_NAMESPACE = 'dxMask';
var BLUR_EVENT = 'blur beforedeactivate';
var EMPTY_CHAR = ' ';

var BaseMaskStrategy = /*#__PURE__*/function () {
  function BaseMaskStrategy(editor) {
    _classCallCheck(this, BaseMaskStrategy);

    this.editor = editor;
    this.DIRECTION = {
      FORWARD: 'forward',
      BACKWARD: 'backward'
    };
    this.NAME = this._getStrategyName();
  }

  _createClass(BaseMaskStrategy, [{
    key: "_getStrategyName",
    value: function _getStrategyName() {
      return 'base';
    }
  }, {
    key: "editorOption",
    value: function editorOption() {
      var _this$editor;

      return (_this$editor = this.editor).option.apply(_this$editor, arguments);
    }
  }, {
    key: "editorInput",
    value: function editorInput() {
      return this.editor._input();
    }
  }, {
    key: "editorCaret",
    value: function editorCaret(newCaret) {
      if (!newCaret) {
        return this.editor._caret();
      }

      this.editor._caret(newCaret);
    }
  }, {
    key: "getHandler",
    value: function getHandler(handlerName) {
      var handler = this["_".concat(handlerName, "Handler")] || function () {};

      return handler.bind(this);
    }
  }, {
    key: "attachEvents",
    value: function attachEvents() {
      var _this = this;

      var $input = this.editorInput();
      this.getHandleEventNames().forEach(function (eventName) {
        var subscriptionName = (0, _index.addNamespace)(eventName.toLowerCase(), MASK_EVENT_NAMESPACE);

        _events_engine.default.on($input, subscriptionName, _this.getEventHandler(eventName));
      });

      this._attachChangeEventHandlers();
    }
  }, {
    key: "getHandleEventNames",
    value: function getHandleEventNames() {
      return ['focusIn', 'focusOut', 'keyDown', 'input', 'paste', 'cut', 'drop'];
    }
  }, {
    key: "getEventHandler",
    value: function getEventHandler(eventName) {
      return this["_".concat(eventName, "Handler")].bind(this);
    }
  }, {
    key: "detachEvents",
    value: function detachEvents() {
      _events_engine.default.off(this.editorInput(), ".".concat(MASK_EVENT_NAMESPACE));
    }
  }, {
    key: "_attachChangeEventHandlers",
    value: function _attachChangeEventHandlers() {
      if ((0, _array.inArray)('change', this.editorOption('valueChangeEvent').split(' ')) === -1) {
        return;
      }

      _events_engine.default.on(this.editorInput(), (0, _index.addNamespace)(BLUR_EVENT, MASK_EVENT_NAMESPACE), function (e) {
        // NOTE: input is focused on caret changing in IE(T304159)
        this._suppressCaretChanging(this._changeHandler, [e]);

        this._changeHandler(e);
      }.bind(this.editor));
    }
  }, {
    key: "_focusInHandler",
    value: function _focusInHandler() {
      this.editor._showMaskPlaceholder();

      this.editor._direction(this.DIRECTION.FORWARD);

      if (!this.editor._isValueEmpty() && this.editorOption('isValid')) {
        this.editor._adjustCaret();
      } else {
        var caret = this.editor._maskRulesChain.first();

        this._caretTimeout = setTimeout(function () {
          this._caret({
            start: caret,
            end: caret
          });
        }.bind(this.editor), 0);
      }
    }
  }, {
    key: "_focusOutHandler",
    value: function _focusOutHandler(event) {
      this.editor._changeHandler(event);

      if (this.editorOption('showMaskMode') === 'onFocus' && this.editor._isValueEmpty()) {
        this.editorOption('text', '');

        this.editor._renderDisplayText('');
      }
    }
  }, {
    key: "_cutHandler",
    value: function _cutHandler(event) {
      var caret = this.editorCaret();
      var selectedText = this.editorInput().val().substring(caret.start, caret.end);

      this.editor._maskKeyHandler(event, function () {
        return (0, _dom.clipboardText)(event, selectedText);
      });
    }
  }, {
    key: "_dropHandler",
    value: function _dropHandler() {
      this._clearDragTimer();

      this._dragTimer = setTimeout(function () {
        this.option('value', this._convertToValue(this._input().val()));
      }.bind(this.editor));
    }
  }, {
    key: "_clearDragTimer",
    value: function _clearDragTimer() {
      clearTimeout(this._dragTimer);
    }
  }, {
    key: "_keyDownHandler",
    value: function _keyDownHandler() {
      this._keyPressHandled = false;
    }
  }, {
    key: "_pasteHandler",
    value: function _pasteHandler(event) {
      var editor = this.editor;
      this._keyPressHandled = true;
      var caret = this.editorCaret();

      editor._maskKeyHandler(event, function () {
        var pastedText = (0, _dom.clipboardText)(event);

        var restText = editor._maskRulesChain.text().substring(caret.end);

        var accepted = editor._handleChain({
          text: pastedText,
          start: caret.start,
          length: pastedText.length
        });

        var newCaret = caret.start + accepted;

        editor._handleChain({
          text: restText,
          start: newCaret,
          length: restText.length
        });

        editor._caret({
          start: newCaret,
          end: newCaret
        });
      });
    }
  }, {
    key: "_autoFillHandler",
    value: function _autoFillHandler(event) {
      var _this2 = this;

      var editor = this.editor;
      var inputVal = this.editorInput().val();
      this._inputHandlerTimer = setTimeout(function () {
        _this2._keyPressHandled = true;

        if (_this2._isAutoFill()) {
          _this2._keyPressHandled = true;

          editor._maskKeyHandler(event, function () {
            editor._handleChain({
              text: inputVal,
              start: 0,
              length: inputVal.length
            });
          });

          editor._validateMask();
        }
      });
    }
  }, {
    key: "_isAutoFill",
    value: function _isAutoFill() {
      var $input = this.editor._input();

      var result = false;

      if (_browser.default.msie && _browser.default.version > 11) {
        result = $input.hasClass('edge-autofilled');
      } else if (_browser.default.webkit) {
        var input = $input.get(0);
        result = input && input.matches(':-webkit-autofill');
      }

      return result;
    }
  }, {
    key: "runWithoutEventProcessing",
    value: function runWithoutEventProcessing(action) {
      var keyPressHandled = this._keyPressHandled;
      this._keyPressHandled = true;
      action();
      this._keyPressHandled = keyPressHandled;
    }
  }, {
    key: "_backspaceHandler",
    value: function _backspaceHandler() {}
  }, {
    key: "_delHandler",
    value: function _delHandler(event) {
      var editor = this.editor;
      this._keyPressHandled = true;

      editor._maskKeyHandler(event, function () {
        return !editor._hasSelection() && editor._handleKey(EMPTY_CHAR);
      });
    }
  }, {
    key: "clean",
    value: function clean() {
      this._clearDragTimer();

      clearTimeout(this._backspaceHandlerTimeout);
      clearTimeout(this._caretTimeout);
      clearTimeout(this._inputHandlerTimer);
    }
  }]);

  return BaseMaskStrategy;
}();

exports.default = BaseMaskStrategy;
module.exports = exports.default;