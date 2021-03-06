"use strict";

exports.Export = void 0;

var _type = require("../../core/utils/type");

var _extend = require("../../core/utils/extend");

var _date = _interopRequireDefault(require("../../localization/date"));

var _number = _interopRequireDefault(require("../../localization/number"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var Export = {
  getFullOptions: function getFullOptions(options) {
    var fullOptions = (0, _extend.extend)({}, options);

    if (!((0, _type.isDefined)(fullOptions.jsPDFDocument) && (0, _type.isObject)(fullOptions.jsPDFDocument))) {
      throw Error('The "jsPDFDocument" field must contain a jsPDF instance.');
    }

    if (!((0, _type.isDefined)(fullOptions.jsPDFDocument.autoTable) && (0, _type.isFunction)(fullOptions.jsPDFDocument.autoTable))) {
      throw Error('The "exportDataGrid" method requires a autoTable plugin for jsPDF object.');
    }

    if (!(0, _type.isDefined)(fullOptions.keepColumnWidths)) {
      fullOptions.keepColumnWidths = true;
    }

    if (!(0, _type.isDefined)(fullOptions.autoTableOptions)) {
      fullOptions.autoTableOptions = this._getDefaultAutoTableOptions();
    } else {
      if (!(0, _type.isObject)(fullOptions.autoTableOptions)) {
        throw Error('The "autoTableOptions" option must be of object type.');
      }

      fullOptions.autoTableOptions = (0, _extend.extend)(true, {}, this._getDefaultAutoTableOptions(), fullOptions.autoTableOptions);
    }

    return fullOptions;
  },
  _getDefaultAutoTableOptions: function _getDefaultAutoTableOptions() {
    return {
      theme: 'plain',
      tableLineColor: 149,
      tableLineWidth: 0.1,
      styles: {
        textColor: 51,
        lineColor: 149,
        lineWidth: 0
      },
      columnStyles: {},
      headStyles: {
        fontStyle: 'normal',
        textColor: 149,
        lineWidth: 0.1
      },
      bodyStyles: {
        lineWidth: 0.1
      },
      head: [],
      body: []
    };
  },
  export: function _export(options) {
    var _this = this;

    var jsPDFDocument = options.jsPDFDocument,
        autoTableOptions = options.autoTableOptions,
        component = options.component,
        keepColumnWidths = options.keepColumnWidths,
        selectedRowsOnly = options.selectedRowsOnly;
    var dataProvider = component.getDataProvider(selectedRowsOnly);
    return new Promise(function (resolve) {
      dataProvider.ready().done(function () {
        var columns = dataProvider.getColumns();
        var styles = dataProvider.getStyles();
        var dataRowsCount = dataProvider.getRowsCount();
        var headerRowCount = dataProvider.getHeaderRowCount();

        if (keepColumnWidths) {
          var pdfColumnWidths = _this._tryGetPdfColumnWidths(autoTableOptions.tableWidth, dataProvider.getColumnsWidths());

          if ((0, _type.isDefined)(pdfColumnWidths) && (0, _type.isDefined)(autoTableOptions.columnStyles)) {
            _this._setColumnWidths(autoTableOptions.columnStyles, pdfColumnWidths);
          }
        }

        for (var rowIndex = 0; rowIndex < dataRowsCount; rowIndex++) {
          var row = [];

          for (var cellIndex = 0; cellIndex < columns.length; cellIndex++) {
            var _dataProvider$getCell = dataProvider.getCellData(rowIndex, cellIndex, true),
                value = _dataProvider$getCell.value,
                gridCell = _dataProvider$getCell.cellSourceData;

            var cellStyle = styles[dataProvider.getStyleId(rowIndex, cellIndex)];
            var pdfCell = {
              content: _this._getFormattedValue(value, cellStyle.format),
              styles: _this._getPDFCellStyles(gridCell.rowType, columns[cellIndex].alignment, cellStyle)
            };

            if (gridCell.rowType === 'group' && !(0, _type.isDefined)(pdfCell.content) && row.length === 1) {
              var _row$0$colSpan;

              row[0].colSpan = (_row$0$colSpan = row[0].colSpan) !== null && _row$0$colSpan !== void 0 ? _row$0$colSpan : 1;
              row[0].colSpan++;
            } else {
              var _pdfCell$content;

              pdfCell.content = (_pdfCell$content = pdfCell.content) !== null && _pdfCell$content !== void 0 ? _pdfCell$content : '';
              row.push(pdfCell);
            }
          }

          if (rowIndex < headerRowCount) {
            autoTableOptions.head.push(row);
          } else {
            autoTableOptions.body.push(row);
          }
        }

        jsPDFDocument.autoTable(autoTableOptions);
        resolve();
      });
    });
  },
  _getFormattedValue: function _getFormattedValue(value, format) {
    if ((0, _type.isDefined)(format)) {
      if ((0, _type.isDate)(value)) {
        return _date.default.format(value, format);
      }

      if ((0, _type.isNumeric)(value)) {
        return _number.default.format(value, format);
      }
    }

    return value;
  },
  _getPDFCellStyles: function _getPDFCellStyles(rowType, columnAlignment, cellStyle) {
    var cellAlignment = cellStyle.alignment,
        bold = cellStyle.bold,
        wrapText = cellStyle.wrapText;
    var align = rowType === 'header' ? columnAlignment : cellAlignment;
    var pdfCellStyle = {};

    if (align) {
      pdfCellStyle['halign'] = align;
    }

    if (rowType !== 'header') {
      if (bold) {
        pdfCellStyle.fontStyle = 'bold';
      }

      if (wrapText) {
        pdfCellStyle.cellWidth = 'wrap';
      }
    }

    return pdfCellStyle;
  },
  _tryGetPdfColumnWidths: function _tryGetPdfColumnWidths(autoTableWidth, columnWidths) {
    if ((0, _type.isNumeric)(autoTableWidth) && (0, _type.isDefined)(columnWidths)) {
      var tableWidth = columnWidths.reduce(function (a, b) {
        return a + b;
      }, 0);
      return columnWidths.map(function (columnWidth) {
        return autoTableWidth * columnWidth / tableWidth;
      });
    }
  },
  _setColumnWidths: function _setColumnWidths(autoTableColumnStyles, pdfColumnWidths) {
    pdfColumnWidths.forEach(function (width, index) {
      autoTableColumnStyles[index] = autoTableColumnStyles[index] || {};
      autoTableColumnStyles[index].cellWidth = width;
    });
  }
};
exports.Export = Export;