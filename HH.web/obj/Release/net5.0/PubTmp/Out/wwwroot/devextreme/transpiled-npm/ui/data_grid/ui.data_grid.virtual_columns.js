"use strict";

var _uiData_grid = _interopRequireDefault(require("./ui.data_grid.core"));

var _uiGrid_core = _interopRequireDefault(require("../grid_core/ui.grid_core.virtual_columns"));

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

_uiData_grid.default.registerModule('virtualColumns', _uiGrid_core.default);