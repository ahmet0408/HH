"use strict";

exports.default = void 0;

var _array = require("../core/utils/array");

var _common = require("../core/utils/common");

var _data = require("../core/utils/data");

var _guid = _interopRequireDefault(require("../core/guid"));

var _type = require("../core/utils/type");

var _errors = _interopRequireDefault(require("../data/errors"));

var _deferred = require("../core/utils/deferred");

var _window = require("../core/utils/window");

var _file_saver = require("../exporter/file_saver");

var _ui = _interopRequireDefault(require("../ui/widget/ui.errors"));

var _jszip = _interopRequireDefault(require("jszip"));

var _provider_base = _interopRequireDefault(require("./provider_base"));

var _errors2 = _interopRequireDefault(require("./errors"));

var _utils = require("./utils");

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

var window = (0, _window.getWindow)();

var ObjectFileSystemProvider = /*#__PURE__*/function (_FileSystemProviderBa) {
  _inherits(ObjectFileSystemProvider, _FileSystemProviderBa);

  var _super = _createSuper(ObjectFileSystemProvider);

  function ObjectFileSystemProvider(options) {
    var _this;

    _classCallCheck(this, ObjectFileSystemProvider);

    options = (0, _common.ensureDefined)(options, {});
    _this = _super.call(this, options);
    var initialArray = options.data;

    if (initialArray && !Array.isArray(initialArray)) {
      throw _errors.default.errors.Error('E4006');
    }

    var itemsExpr = options.itemsExpr || 'items';
    _this._subFileItemsGetter = (0, _data.compileGetter)(itemsExpr);
    _this._subFileItemsSetter = _this._getSetter(itemsExpr);
    var contentExpr = options.contentExpr || 'content';
    _this._contentGetter = (0, _data.compileGetter)(contentExpr);
    _this._contentSetter = _this._getSetter(contentExpr);

    var nameExpr = _this._getNameExpr(options);

    _this._nameSetter = _this._getSetter(nameExpr);

    var isDirExpr = _this._getIsDirExpr(options);

    _this._getIsDirSetter = _this._getSetter(isDirExpr);

    var keyExpr = _this._getKeyExpr(options);

    _this._keySetter = _this._getSetter(keyExpr);

    var sizeExpr = _this._getSizeExpr(options);

    _this._sizeSetter = _this._getSetter(sizeExpr);

    var dateModifiedExpr = _this._getDateModifiedExpr(options);

    _this._dateModifiedSetter = _this._getSetter(dateModifiedExpr);
    _this._data = initialArray || [];
    return _this;
  }

  _createClass(ObjectFileSystemProvider, [{
    key: "getItems",
    value: function getItems(parentDir) {
      var _this2 = this;

      return this._executeActionAsDeferred(function () {
        return _this2._getItems(parentDir);
      }, true);
    }
  }, {
    key: "renameItem",
    value: function renameItem(item, name) {
      var _this3 = this;

      return this._executeActionAsDeferred(function () {
        return _this3._renameItemCore(item, name);
      });
    }
  }, {
    key: "_renameItemCore",
    value: function _renameItemCore(item, name) {
      if (!item) {
        return;
      }

      var dataItem = this._findDataObject(item);

      this._nameSetter(dataItem, name);

      item.name = name;
      item.key = this._ensureDataObjectKey(dataItem);
    }
  }, {
    key: "createDirectory",
    value: function createDirectory(parentDir, name) {
      var _this4 = this;

      return this._executeActionAsDeferred(function () {
        _this4._validateDirectoryExists(parentDir);

        _this4._createDataObject(parentDir, name, true);
      });
    }
  }, {
    key: "deleteItems",
    value: function deleteItems(items) {
      var _this5 = this;

      return items.map(function (item) {
        return _this5._executeActionAsDeferred(function () {
          return _this5._deleteItem(item);
        });
      });
    }
  }, {
    key: "moveItems",
    value: function moveItems(items, destinationDir) {
      var _this6 = this;

      var destinationDataItem = this._findDataObject(destinationDir);

      var array = this._getDirectoryDataItems(destinationDataItem);

      var deferreds = items.map(function (item) {
        return _this6._executeActionAsDeferred(function () {
          _this6._checkAbilityToMoveOrCopyItem(item, destinationDir);

          var dataItem = _this6._findDataObject(item);

          _this6._deleteItem(item);

          array.push(dataItem);
        });
      });

      this._updateHasSubDirs(destinationDir);

      return deferreds;
    }
  }, {
    key: "copyItems",
    value: function copyItems(items, destinationDir) {
      var _this7 = this;

      var destinationDataItem = this._findDataObject(destinationDir);

      var array = this._getDirectoryDataItems(destinationDataItem);

      var deferreds = items.map(function (item) {
        return _this7._executeActionAsDeferred(function () {
          _this7._checkAbilityToMoveOrCopyItem(item, destinationDir);

          var dataItem = _this7._findDataObject(item);

          var copiedItem = _this7._createCopy(dataItem);

          array.push(copiedItem);
        });
      });

      this._updateHasSubDirs(destinationDir);

      return deferreds;
    }
  }, {
    key: "uploadFileChunk",
    value: function uploadFileChunk(fileData, chunksInfo, destinationDirectory) {
      var _this8 = this;

      if (chunksInfo.chunkIndex > 0) {
        return chunksInfo.customData.deferred;
      }

      this._validateDirectoryExists(destinationDirectory);

      var deferred = chunksInfo.customData.deferred = new _deferred.Deferred();

      var reader = this._createFileReader();

      reader.readAsDataURL(fileData);

      reader.onload = function () {
        var content = reader.result.split(',')[1];

        var dataObj = _this8._createDataObject(destinationDirectory, fileData.name, false);

        _this8._sizeSetter(dataObj, fileData.size);

        _this8._dateModifiedSetter(dataObj, fileData.lastModifiedDate);

        _this8._contentSetter(dataObj, content);

        deferred.resolve();
      };

      reader.onerror = function (error) {
        return deferred.reject(error);
      };

      return deferred;
    }
  }, {
    key: "downloadItems",
    value: function downloadItems(items) {
      if (items.length === 1) {
        this._downloadSingleFile(items[0]);
      } else {
        this._downloadMultipleFiles(items);
      }
    }
  }, {
    key: "_downloadSingleFile",
    value: function _downloadSingleFile(file) {
      var content = this._getFileContent(file);

      var byteString = window.atob(content);
      var arrayBuffer = new ArrayBuffer(byteString.length);
      var array = new Uint8Array(arrayBuffer);

      for (var i = 0; i < byteString.length; i++) {
        array[i] = byteString.charCodeAt(i);
      }

      var blob = new window.Blob([arrayBuffer], {
        type: 'application/octet-stream'
      });

      _file_saver.fileSaver.saveAs(file.name, null, blob);
    }
  }, {
    key: "_downloadMultipleFiles",
    value: function _downloadMultipleFiles(files) {
      var _this9 = this;

      var jsZip = getJSZip();
      var zip = new jsZip();
      files.forEach(function (file) {
        return zip.file(file.name, _this9._getFileContent(file), {
          base64: true
        });
      });
      var options = {
        type: 'blob',
        compression: 'DEFLATE',
        mimeType: 'application/zip'
      };
      var deferred = new _deferred.Deferred();

      if (zip.generateAsync) {
        zip.generateAsync(options).then(deferred.resolve);
      } else {
        deferred.resolve(zip.generate(options));
      }

      deferred.done(function (blob) {
        return _file_saver.fileSaver.saveAs('files.zip', null, blob);
      });
    }
  }, {
    key: "_getFileContent",
    value: function _getFileContent(file) {
      var dataItem = this._findDataObject(file);

      return this._contentGetter(dataItem) || '';
    }
  }, {
    key: "_validateDirectoryExists",
    value: function _validateDirectoryExists(directoryInfo) {
      if (!this._isFileItemExists(directoryInfo) || this._isDirGetter(directoryInfo.fileItem)) {
        throw {
          errorId: _errors2.default.DirectoryNotFound,
          fileItem: directoryInfo
        };
      }
    }
  }, {
    key: "_checkAbilityToMoveOrCopyItem",
    value: function _checkAbilityToMoveOrCopyItem(item, destinationDir) {
      var _this10 = this;

      var dataItem = this._findDataObject(item);

      var itemKey = this._getKeyFromDataObject(dataItem, item.parentPath);

      var pathInfo = destinationDir.getFullPathInfo();
      var currentPath = '';
      pathInfo.forEach(function (info) {
        currentPath = (0, _utils.pathCombine)(currentPath, info.name);

        var pathKey = _this10._getDataObjectKey(info.key, currentPath);

        if (pathKey === itemKey) {
          throw {
            errorId: _errors2.default.Other,
            fileItem: item
          };
        }
      });
    }
  }, {
    key: "_createDataObject",
    value: function _createDataObject(parentDir, name, isDirectory) {
      var dataObj = {};

      this._nameSetter(dataObj, name);

      this._getIsDirSetter(dataObj, isDirectory);

      this._keySetter(dataObj, String(new _guid.default()));

      var parentDataItem = this._findDataObject(parentDir);

      var array = this._getDirectoryDataItems(parentDataItem);

      array.push(dataObj);

      if (isDirectory) {
        this._updateHasSubDirs(parentDir);
      }

      return dataObj;
    }
  }, {
    key: "_createCopy",
    value: function _createCopy(dataObj) {
      var _this11 = this;

      var copyObj = {};

      this._nameSetter(copyObj, this._nameGetter(dataObj));

      this._getIsDirSetter(copyObj, this._isDirGetter(dataObj));

      var items = this._subFileItemsGetter(dataObj);

      if (Array.isArray(items)) {
        var itemsCopy = [];
        items.forEach(function (childItem) {
          var childCopy = _this11._createCopy(childItem);

          itemsCopy.push(childCopy);
        });

        this._subFileItemsSetter(copyObj, itemsCopy);
      }

      return copyObj;
    }
  }, {
    key: "_deleteItem",
    value: function _deleteItem(fileItem) {
      var dataItem = this._findDataObject(fileItem);

      var parentDirDataObj = this._findFileItemObj(fileItem.pathInfo);

      var array = this._getDirectoryDataItems(parentDirDataObj);

      var index = array.indexOf(dataItem);
      array.splice(index, 1);
    }
  }, {
    key: "_getDirectoryDataItems",
    value: function _getDirectoryDataItems(directoryDataObj) {
      if (!directoryDataObj) {
        return this._data;
      }

      var dataItems = this._subFileItemsGetter(directoryDataObj);

      if (!Array.isArray(dataItems)) {
        dataItems = [];

        this._subFileItemsSetter(directoryDataObj, dataItems);
      }

      return dataItems;
    }
  }, {
    key: "_getItems",
    value: function _getItems(parentDir) {
      this._validateDirectoryExists(parentDir);

      var pathInfo = parentDir.getFullPathInfo();
      var parentDirKey = pathInfo && pathInfo.length > 0 ? pathInfo[pathInfo.length - 1].key : null;
      var dirFileObjects = this._data;

      if (parentDirKey) {
        var directoryEntry = this._findFileItemObj(pathInfo);

        dirFileObjects = directoryEntry && this._subFileItemsGetter(directoryEntry) || [];
      }

      this._ensureKeysForDuplicateNameItems(dirFileObjects);

      return this._convertDataObjectsToFileItems(dirFileObjects, pathInfo);
    }
  }, {
    key: "_ensureKeysForDuplicateNameItems",
    value: function _ensureKeysForDuplicateNameItems(dataObjects) {
      var _this12 = this;

      var names = {};
      dataObjects.forEach(function (obj) {
        var name = _this12._nameGetter(obj);

        if (names[name]) {
          _this12._ensureDataObjectKey(obj);
        } else {
          names[name] = true;
        }
      });
    }
  }, {
    key: "_findDataObject",
    value: function _findDataObject(item) {
      if (item.isRoot()) {
        return null;
      }

      var result = this._findFileItemObj(item.getFullPathInfo());

      if (!result) {
        throw {
          errorId: item.isDirectory ? _errors2.default.DirectoryNotFound : _errors2.default.FileNotFound,
          fileItem: item
        };
      }

      return result;
    }
  }, {
    key: "_findFileItemObj",
    value: function _findFileItemObj(pathInfo) {
      var _this13 = this;

      if (!Array.isArray(pathInfo)) {
        pathInfo = [];
      }

      var currentPath = '';
      var fileItemObj = null;
      var fileItemObjects = this._data;

      var _loop = function _loop(i) {
        fileItemObj = (0, _array.find)(fileItemObjects, function (item) {
          var hasCorrectFileItemType = _this13._isDirGetter(item) || i === pathInfo.length - 1;
          return _this13._getKeyFromDataObject(item, currentPath) === pathInfo[i].key && _this13._nameGetter(item) === pathInfo[i].name && hasCorrectFileItemType;
        });

        if (fileItemObj) {
          currentPath = (0, _utils.pathCombine)(currentPath, _this13._nameGetter(fileItemObj));
          fileItemObjects = _this13._subFileItemsGetter(fileItemObj);
        }
      };

      for (var i = 0; i < pathInfo.length && (i === 0 || fileItemObj); i++) {
        _loop(i);
      }

      return fileItemObj;
    }
  }, {
    key: "_getKeyFromDataObject",
    value: function _getKeyFromDataObject(dataObj, defaultKeyPrefix) {
      var key = this._keyGetter(dataObj);

      var relativeName = (0, _utils.pathCombine)(defaultKeyPrefix, this._nameGetter(dataObj));
      return this._getDataObjectKey(key, relativeName);
    }
  }, {
    key: "_getDataObjectKey",
    value: function _getDataObjectKey(key, relativeName) {
      return key ? key : relativeName;
    }
  }, {
    key: "_ensureDataObjectKey",
    value: function _ensureDataObjectKey(dataObj) {
      var key = this._keyGetter(dataObj);

      if (!key) {
        key = String(new _guid.default());

        this._keySetter(dataObj, key);
      }

      return key;
    }
  }, {
    key: "_updateHasSubDirs",
    value: function _updateHasSubDirs(dir) {
      if (dir && !dir.isRoot()) {
        var dataItem = this._findDataObject(dir);

        dir.hasSubDirectories = this._hasSubDirs(dataItem);
      }
    }
  }, {
    key: "_hasSubDirs",
    value: function _hasSubDirs(dataObj) {
      var subItems = (0, _common.ensureDefined)(this._subFileItemsGetter(dataObj), []);

      if (!Array.isArray(subItems)) {
        return true;
      }

      for (var i = 0; i < subItems.length; i++) {
        if (this._isDirGetter(subItems[i]) === true) {
          return true;
        }
      }

      return false;
    }
  }, {
    key: "_getSetter",
    value: function _getSetter(expr) {
      return (0, _type.isFunction)(expr) ? expr : (0, _data.compileSetter)(expr);
    }
  }, {
    key: "_isFileItemExists",
    value: function _isFileItemExists(fileItem) {
      return fileItem.isDirectory && fileItem.isRoot() || !!this._findFileItemObj(fileItem.getFullPathInfo());
    }
  }, {
    key: "_createFileReader",
    value: function _createFileReader() {
      return new window.FileReader();
    }
  }]);

  return ObjectFileSystemProvider;
}(_provider_base.default);

function getJSZip() {
  if (!_jszip.default) {
    throw _ui.default.Error('E1041', 'JSZip');
  }

  return _jszip.default;
}

var _default = ObjectFileSystemProvider;
exports.default = _default;
module.exports = exports.default;