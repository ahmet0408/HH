"use strict";

var _dxChart;

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

var dxChart = (_dxChart = {
  seriesTemplate: {
    /**
    * @name dxChartOptions.seriesTemplate.nameField
    * @type string
    * @default 'series'
    */
    nameField: 'series',

    /**
    * @name dxChartOptions.seriesTemplate.customizeSeries
    * @type function(seriesName)
    * @type_function_param1 seriesName:any
    * @type_function_return ChartSeries
    */
    customizeSeries: function customizeSeries() {}
  },
  resolveLabelOverlapping: "none",
  seriesSelectionMode: 'single',
  containerBackgroundColor: '#FFFFFF',
  onSeriesClick: function onSeriesClick() {},
  onLegendClick: function onLegendClick() {},
  barGroupPadding: 0.3,
  barGroupWidth: undefined,
  negativesAsZeroes: false,
  commonSeriesSettings: {
    type: 'line',
    line: {},
    fullstackedline: {},
    fullstackedspline: {},
    stackedline: {},
    stackedspline: {},
    stepline: {},
    area: {},
    fullstackedarea: {},
    fullstackedsplinearea: {},
    stackedarea: {},
    stackedsplinearea: {},
    steparea: {},
    bar: {},
    fullstackedbar: {},
    stackedbar: {},
    spline: {},
    splinearea: {},
    scatter: {},
    candlestick: {},
    stock: {},
    rangebar: {},
    rangearea: {},
    bubble: {}
  },
  defaultPane: undefined,
  resizePanesOnZoom: false,
  adjustOnZoom: true,
  autoHidePointMarkers: true,
  rotated: false,
  synchronizeMultiAxes: true,
  commonPaneSettings: {
    backgroundColor: 'none',
    border: {
      /**
      * @name dxChartOptions.commonPaneSettings.border.visible
      * @type boolean
      * @default false
      */
      visible: false,

      /**
      * @name dxChartOptions.commonPaneSettings.border.top
      * @type boolean
      * @default true
      */
      top: true,

      /**
      * @name dxChartOptions.commonPaneSettings.border.bottom
      * @type boolean
      * @default true
      */
      bottom: true,

      /**
      * @name dxChartOptions.commonPaneSettings.border.left
      * @type boolean
      * @default true
      */
      left: true,

      /**
      * @name dxChartOptions.commonPaneSettings.border.right
      * @type boolean
      * @default true
      */
      right: true,

      /**
      * @name dxChartOptions.commonPaneSettings.border.color
      * @type string
      * @default '#d3d3d3'
      */
      color: '#d3d3d3',

      /**
      * @name dxChartOptions.commonPaneSettings.border.dashStyle
      * @type Enums.DashStyle
      * @default 'solid'
      */
      dashStyle: 'solid',

      /**
      * @name dxChartOptions.commonPaneSettings.border.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.commonPaneSettings.border.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    }
  },
  panes: [{
    name: undefined,
    height: undefined
  }],
  dataPrepareSettings: {
    /**
    * @name dxChartOptions.dataPrepareSettings.checkTypeForAllData
    * @type boolean
    * @default false
    */
    checkTypeForAllData: false,

    /**
    * @name dxChartOptions.dataPrepareSettings.convertToAxisDataType
    * @type boolean
    * @default true
    */
    convertToAxisDataType: true,

    /**
    * @name dxChartOptions.dataPrepareSettings.sortingMethod
    * @type boolean|function(a,b)
    * @type_function_param1 a:object
    * @type_function_param2 b:object
    * @type_function_return Number
    * @default true
    */
    sortingMethod: true
  },
  scrollBar: {
    /**
    * @name dxChartOptions.scrollBar.visible
    * @type boolean
    * @default false
    */
    visible: false,

    /**
    * @name dxChartOptions.scrollBar.offset
    * @type number
    * @default 5
    */
    offset: 5,

    /**
    * @name dxChartOptions.scrollBar.color
    * @type string
    * @default 'gray'
    */
    color: "gray",

    /**
    * @name dxChartOptions.scrollBar.width
    * @type number
    * @default 10
    */
    width: 10,

    /**
    * @name dxChartOptions.scrollBar.opacity
    * @type number
    * @default undefined
    */
    opacity: undefined,

    /**
    * @name dxChartOptions.scrollBar.position
    * @type Enums.Position
    * @default 'top'
    */
    position: 'top'
  },
  zoomAndPan: {
    /**
    * @name dxChartOptions.zoomAndPan.valueAxis
    * @type Enums.ChartZoomAndPanMode
    * @default 'none'
    */
    valueAxis: 'none',

    /**
    * @name dxChartOptions.zoomAndPan.argumentAxis
    * @type Enums.ChartZoomAndPanMode
    * @default 'none'
    */
    argumentAxis: 'none',

    /**
    * @name dxChartOptions.zoomAndPan.dragToZoom
    * @type boolean
    * @default false
    */
    dragToZoom: false,

    /**
    * @name dxChartOptions.zoomAndPan.dragBoxStyle
    * @type object
    */
    dragBoxStyle: {
      /**
      * @name dxChartOptions.zoomAndPan.dragBoxStyle.color
      * @type string
      * @default undefined
      */
      color: undefined,

      /**
      * @name dxChartOptions.zoomAndPan.dragBoxStyle.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    },

    /**
    * @name dxChartOptions.zoomAndPan.panKey
    * @type Enums.EventKeyModifier
    * @default 'shift'
    */
    panKey: 'shift',

    /**
    * @name dxChartOptions.zoomAndPan.allowMouseWheel
    * @type boolean
    * @default true
    */
    allowMouseWheel: true,

    /**
    * @name dxChartOptions.zoomAndPan.allowTouchGestures
    * @type boolean
    * @default true
    */
    allowTouchGestures: true
  },
  stickyHovering: true,
  crosshair: {
    /**
    * @name dxChartOptions.crosshair.enabled
    * @type boolean
    * @default false
    */
    enabled: false,

    /**
    * @name dxChartOptions.crosshair.color
    * @type string
    * @default '#f05b41'
    */
    color: '#f05b41',

    /**
    * @name dxChartOptions.crosshair.width
    * @type number
    * @default 1
    */
    width: 1,

    /**
    * @name dxChartOptions.crosshair.dashStyle
    * @type Enums.DashStyle
    * @default 'solid'
    */
    dashStyle: 'solid',

    /**
    * @name dxChartOptions.crosshair.opacity
    * @type number
    * @default undefined
    */
    opacity: undefined,

    /**
    * @name dxChartOptions.crosshair.label
    * @type object
    */
    label: {
      /**
      * @name dxChartOptions.crosshair.label.backgroundColor
      * @type string
      * @default "#f05b41"
      */
      backgroundColor: "#f05b41",

      /**
       * @name dxChartOptions.crosshair.label.visible
       * @type boolean
       * @default false
       */
      visible: false,

      /**
      * @name dxChartOptions.crosshair.label.font
      * @type Font
      * @default '#FFFFFF' @prop color
       */
      font: {
        family: undefined,
        weight: 400,
        color: '#FFFFFF',
        size: 12,
        opacity: undefined
      },

      /**
      * @name dxChartOptions.crosshair.label.format
      * @extends CommonVizFormat
      */
      format: '',

      /**
      * @name dxChartOptions.crosshair.label.customizeText
      * @type function(info)
      * @type_function_param1 info:object
      * @type_function_param1_field1 value:Date|Number|string
      * @type_function_param1_field2 valueText:string
      * @type_function_param1_field3 point:chartPointObject
      * @type_function_return string
      * @notUsedInTheme
      */
      customizeText: undefined
    },

    /**
    * @name dxChartOptions.crosshair.verticalLine
    * @type object | boolean
    */
    verticalLine: {
      /**
      * @name dxChartOptions.crosshair.verticalLine.visible
      * @type boolean
      * @default true
      */
      visible: true,

      /**
      * @name dxChartOptions.crosshair.verticalLine.color
      * @type string
      * @default "#f05b41"
      */
      color: "#f05b41",

      /**
      * @name dxChartOptions.crosshair.verticalLine.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.crosshair.verticalLine.dashStyle
      * @type Enums.DashStyle
      * @default 'solid'
      */
      dashStyle: 'solid',

      /**
      * @name dxChartOptions.crosshair.verticalLine.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined,

      /**
      * @name dxChartOptions.crosshair.verticalLine.label
      * @type object
      */
      label: {
        /**
        * @name dxChartOptions.crosshair.verticalLine.label.backgroundColor
        * @type string
        * @default "#f05b41"
        */
        backgroundColor: "#f05b41",

        /**
         * @name dxChartOptions.crosshair.verticalLine.label.visible
         * @type boolean
         * @default false
         */
        visible: false,

        /**
        * @name dxChartOptions.crosshair.verticalLine.label.font
        * @type Font
        * @default '#FFFFFF' @prop color
         */
        font: {
          family: undefined,
          weight: 400,
          color: '#FFFFFF',
          size: 12,
          opacity: undefined
        },

        /**
        * @name dxChartOptions.crosshair.verticalLine.label.format
        * @extends CommonVizFormat
        */
        format: '',

        /**
        * @name dxChartOptions.crosshair.verticalLine.label.customizeText
        * @type function(info)
        * @type_function_param1 info:object
        * @type_function_param1_field1 value:Date|Number|string
        * @type_function_param1_field2 valueText:string
        * @type_function_param1_field3 point:chartPointObject
        * @type_function_return string
        * @notUsedInTheme
        */
        customizeText: undefined
      }
    },

    /**
    * @name dxChartOptions.crosshair.horizontalLine
    * @type object | boolean
    */
    horizontalLine: {
      /**
      * @name dxChartOptions.crosshair.horizontalLine.visible
      * @type boolean
      * @default true
      */
      visible: true,

      /**
      * @name dxChartOptions.crosshair.horizontalLine.color
      * @type string
      * @default "#f05b41"
      */
      color: "#f05b41",

      /**
      * @name dxChartOptions.crosshair.horizontalLine.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.crosshair.horizontalLine.dashStyle
      * @type Enums.DashStyle
      * @default 'solid'
      */
      dashStyle: 'solid',

      /**
      * @name dxChartOptions.crosshair.horizontalLine.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined,

      /**
      * @name dxChartOptions.crosshair.horizontalLine.label
      * @type object
      */
      label: {
        /**
        * @name dxChartOptions.crosshair.horizontalLine.label.backgroundColor
        * @type string
        * @default "#f05b41"
        */
        backgroundColor: "#f05b41",

        /**
         * @name dxChartOptions.crosshair.horizontalLine.label.visible
         * @type boolean
         * @default false
         */
        visible: false,

        /**
        * @name dxChartOptions.crosshair.horizontalLine.label.font
        * @type Font
        * @default '#FFFFFF' @prop color
         */
        font: {
          family: undefined,
          weight: 400,
          color: '#FFFFFF',
          size: 12,
          opacity: undefined
        },

        /**
        * @name dxChartOptions.crosshair.horizontalLine.label.format
        * @extends CommonVizFormat
        */
        format: '',

        /**
        * @name dxChartOptions.crosshair.horizontalLine.label.customizeText
        * @type function(info)
        * @type_function_param1 info:object
        * @type_function_param1_field1 value:Date|Number|string
        * @type_function_param1_field2 valueText:string
        * @type_function_param1_field3 point:chartPointObject
        * @type_function_return string
        * @notUsedInTheme
        */
        customizeText: undefined
      }
    }
  },
  onArgumentAxisClick: function onArgumentAxisClick() {},
  legend: {
    customizeText: undefined,
    customizeHint: undefined,
    hoverMode: 'includePoints',
    position: 'outside'
  },
  commonAxisSettings: {
    discreteAxisDivisionMode: 'betweenLabels',
    visible: true,
    color: '#767676',
    width: 1,
    opacity: undefined,
    placeholderSize: null,
    breakStyle: {
      /**
      * @name dxChartOptions.commonAxisSettings.breakStyle.width
      * @type number
      * @default 5
      */
      width: 5,

      /**
      * @name dxChartOptions.commonAxisSettings.breakStyle.color
      * @type string
      * @default "#ababab"
      */
      color: "#ababab",

      /**
      * @name dxChartOptions.commonAxisSettings.breakStyle.line
      * @type Enums.ScaleBreakLineStyle
      * @default "waved"
      */
      line: "waved"
    },
    label: {
      alignment: undefined,
      visible: true,
      rotationAngle: 90,
      staggeringSpacing: 5,
      displayMode: "standard",
      overlappingBehavior: "hide",
      indentFromAxis: 10,
      font: {
        family: undefined,
        weight: 400,
        color: '#767676',
        size: 12,
        opacity: undefined
      },
      wordWrap: "normal",
      textOverflow: "none",
      position: 'outside'
    },
    grid: {
      /**
      * @name dxChartOptions.commonAxisSettings.grid.visible
      * @type boolean
      * @default false
      */
      visible: false,

      /**
      * @name dxChartOptions.commonAxisSettings.grid.color
      * @type string
      * @default '#d3d3d3'
      */
      color: '#d3d3d3',

      /**
      * @name dxChartOptions.commonAxisSettings.grid.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.commonAxisSettings.grid.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    },
    minorGrid: {
      /**
      * @name dxChartOptions.commonAxisSettings.minorGrid.visible
      * @type boolean
      * @default false
      */
      visible: false,

      /**
      * @name dxChartOptions.commonAxisSettings.minorGrid.color
      * @type string
      * @default '#d3d3d3'
      */
      color: '#d3d3d3',

      /**
      * @name dxChartOptions.commonAxisSettings.minorGrid.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.commonAxisSettings.minorGrid.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    },
    tick: {
      /**
      * @name dxChartOptions.commonAxisSettings.tick.visible
      * @type boolean
      * @default true
      */
      visible: true,

      /**
      * @name dxChartOptions.commonAxisSettings.tick.color
      * @type string
      * @default '#767676'
      */
      color: '#767676',

      /**
      * @name dxChartOptions.commonAxisSettings.tick.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined,

      /**
      * @name dxChartOptions.commonAxisSettings.tick.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.commonAxisSettings.tick.length
      * @type number
      * @default 7
      */
      length: 7,

      /**
      * @name dxChartOptions.commonAxisSettings.tick.shift
      * @type number
      * @default 3
      */
      shift: 3
    },
    minorTick: {
      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.visible
      * @type boolean
      * @default false
      */
      visible: false,

      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.color
      * @type string
      * @default '#767676'
      */
      color: '#767676',

      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.opacity
      * @type number
      * @default 0.3
      */
      opacity: 0.3,

      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.length
      * @type number
      * @default 7
      */
      length: 7,

      /**
      * @name dxChartOptions.commonAxisSettings.minorTick.shift
      * @type number
      * @default 3
      */
      shift: 3
    },
    title: {
      font: {
        family: undefined,
        weight: 400,
        color: '#767676',
        size: 16,
        opacity: undefined
      },
      margin: 6,
      alignment: 'center',
      wordWrap: "normal",
      textOverflow: "ellipsis"
    },
    stripStyle: {
      paddingLeftRight: 10,
      paddingTopBottom: 5,
      label: {
        horizontalAlignment: 'left',
        verticalAlignment: 'center',
        font: {
          family: undefined,
          weight: 400,
          color: '#767676',
          size: 12,
          opacity: undefined
        }
      }
    },
    constantLineStyle: {
      paddingLeftRight: 10,
      paddingTopBottom: 10,
      width: 1,
      dashStyle: 'solid',
      color: '#000000',
      label: {
        visible: true,
        position: 'inside',
        font: {
          family: undefined,
          weight: 400,
          color: '#767676',
          size: 12,
          opacity: undefined
        }
      }
    },
    minValueMargin: 0,
    maxValueMargin: 0,
    valueMarginsEnabled: true,
    inverted: false,
    allowDecimals: undefined,
    endOnTick: undefined
  },
  argumentAxis: {
    tickInterval: {},
    minorTickInterval: {},
    minorTickCount: undefined,
    title: {
      text: undefined
    },
    workdaysOnly: false,
    workWeek: [1, 2, 3, 4, 5],
    holidays: undefined,
    breaks: undefined,
    singleWorkdays: undefined,
    aggregationGroupWidth: 10,
    aggregationInterval: undefined,
    aggregateByCategory: false,
    label: {
      customizeText: undefined,
      customizeHint: undefined,
      format: ''
    },
    strips: [{
      startValue: undefined,
      endValue: undefined,
      color: undefined,
      label: {
        text: undefined
      }
    }],
    constantLineStyle: {
      label: {
        horizontalAlignment: 'right',
        verticalAlignment: 'top'
      }
    },
    constantLines: [{
      value: undefined,
      displayBehindSeries: false,
      extendAxis: false,
      label: {
        text: undefined,
        horizontalAlignment: 'right',
        verticalAlignment: 'top'
      }
    }],
    position: 'bottom',
    customPosition: undefined,
    customPositionAxis: undefined,
    offset: undefined,
    min: undefined,
    max: undefined,
    visualRange: undefined,
    wholeRange: undefined,
    visualRangeUpdateMode: "auto",
    minVisualRangeLength: undefined,
    axisDivisionFactor: 70,
    categories: [],
    type: undefined,
    logarithmBase: 10,
    linearThreshold: undefined,
    argumentType: undefined,
    hoverMode: 'none',
    endOnTick: false
  },
  valueAxis: {
    showZero: undefined,
    synchronizedValue: undefined,
    multipleAxesSpacing: 5,
    tickInterval: {},
    minorTickInterval: {},
    minorTickCount: undefined,
    breaks: undefined,
    autoBreaksEnabled: false,
    maxAutoBreakCount: 4,
    title: {
      text: undefined
    },
    name: undefined,
    label: {
      customizeText: undefined,
      customizeHint: undefined,
      format: ''
    },
    strips: [{
      startValue: undefined,
      endValue: undefined,
      color: undefined,
      label: {
        text: undefined
      }
    }],
    constantLineStyle: {
      label: {
        horizontalAlignment: 'left',
        verticalAlignment: 'top'
      }
    },
    constantLines: [{
      value: undefined,
      displayBehindSeries: false,
      extendAxis: false,
      label: {
        text: undefined,
        horizontalAlignment: 'left',
        verticalAlignment: 'top'
      }
    }],
    position: 'left',
    customPosition: undefined,
    offset: undefined,
    min: undefined,
    max: undefined,
    visualRange: undefined,
    wholeRange: undefined,
    visualRangeUpdateMode: "auto",
    minVisualRangeLength: undefined,
    axisDivisionFactor: 40,
    categories: [],
    type: undefined,
    logarithmBase: 10,
    linearThreshold: undefined,
    valueType: undefined,
    pane: undefined,
    endOnTick: undefined
  },
  tooltip: {
    location: 'center'
  },
  commonAnnotationSettings: undefined,
  annotations: [{}],
  customizeAnnotation: undefined,
  onSeriesHoverChanged: function onSeriesHoverChanged() {},
  onSeriesSelectionChanged: function onSeriesSelectionChanged() {},
  onZoomStart: function onZoomStart() {},
  onZoomEnd: function onZoomEnd() {},
  series: undefined,
  minBubbleSize: 12,
  maxBubbleSize: 0.2,
  zoomArgument: function zoomArgument() {},
  resetVisualRange: function resetVisualRange() {},
  getValueAxis: function getValueAxis() {}
}, _defineProperty(_dxChart, "getValueAxis", function getValueAxis(name) {}), _defineProperty(_dxChart, "getArgumentAxis", function getArgumentAxis() {}), _dxChart);
var dxPieChart = {
  getInnerRadius: function getInnerRadius() {},
  seriesTemplate: {
    /**
    * @name dxPieChartOptions.seriesTemplate.nameField
    * @type string
    * @default 'series'
    */
    nameField: 'series',

    /**
    * @name dxPieChartOptions.seriesTemplate.customizeSeries
    * @type function(seriesName)
    * @type_function_param1 seriesName:any
    * @type_function_return PieChartSeries
    */
    customizeSeries: function customizeSeries() {}
  },
  legend: {
    hoverMode: 'allArgumentPoints',
    customizeText: undefined,
    customizeHint: undefined,
    customizeItems: undefined,
    markerTemplate: undefined
  },
  resolveLabelOverlapping: "none",
  palette: [],
  series: undefined,
  type: 'pie',
  commonSeriesSettings: {},
  diameter: undefined,
  minDiameter: 0.5,
  segmentsDirection: 'clockwise',
  startAngle: 0,
  innerRadius: 0.5,
  onLegendClick: function onLegendClick() {},
  sizeGroup: undefined,
  centerTemplate: undefined,
  commonAnnotationSettings: undefined,
  annotations: [{}],
  customizeAnnotation: undefined
};
var dxPolarChart = {
  seriesTemplate: {
    /**
    * @name dxPolarChartOptions.seriesTemplate.nameField
    * @type string
    * @default 'series'
    */
    nameField: 'series',

    /**
    * @name dxPolarChartOptions.seriesTemplate.customizeSeries
    * @type function(seriesName)
    * @type_function_param1 seriesName:any
    * @type_function_return PolarChartSeries
    */
    customizeSeries: function customizeSeries() {}
  },
  useSpiderWeb: false,
  resolveLabelOverlapping: "none",
  seriesSelectionMode: 'single',
  containerBackgroundColor: '#FFFFFF',
  onSeriesClick: function onSeriesClick() {},
  onLegendClick: function onLegendClick() {},
  barGroupPadding: 0.3,
  barGroupWidth: undefined,
  negativesAsZeroes: false,
  commonSeriesSettings: {
    type: 'scatter',
    line: {},
    area: {},
    bar: {},
    stackedbar: {},
    scatter: {}
  },
  dataPrepareSettings: {
    /**
    * @name dxPolarChartOptions.dataPrepareSettings.checkTypeForAllData
    * @type boolean
    * @default false
    */
    checkTypeForAllData: false,

    /**
    * @name dxPolarChartOptions.dataPrepareSettings.convertToAxisDataType
    * @type boolean
    * @default true
    */
    convertToAxisDataType: true,

    /**
    * @name dxPolarChartOptions.dataPrepareSettings.sortingMethod
    * @type boolean|function(a,b)
    * @type_function_param1 a:object
    * @type_function_param1_field1 arg:Date|Number|string
    * @type_function_param1_field2 val:Date|Number|string
    * @type_function_param2 b:object
    * @type_function_param2_field1 arg:Date|Number|string
    * @type_function_param2_field2 val:Date|Number|string
    * @type_function_return Number
    * @default true
    */
    sortingMethod: true
  },
  onArgumentAxisClick: function onArgumentAxisClick() {},
  legend: {
    customizeText: undefined,
    customizeHint: undefined,
    hoverMode: 'includePoints'
  },
  commonAxisSettings: {
    discreteAxisDivisionMode: 'betweenLabels',
    visible: true,
    color: '#767676',
    width: 1,
    opacity: undefined,
    label: {
      visible: true,
      overlappingBehavior: 'hide',
      indentFromAxis: 5,
      font: {
        family: undefined,
        weight: 400,
        color: '#767676',
        size: 12,
        opacity: undefined
      }
    },
    grid: {
      /**
      * @name dxPolarChartOptions.commonAxisSettings.grid.visible
      * @type boolean
      * @default true
      */
      visible: true,

      /**
      * @name dxPolarChartOptions.commonAxisSettings.grid.color
      * @type string
      * @default '#d3d3d3'
      */
      color: '#d3d3d3',

      /**
      * @name dxPolarChartOptions.commonAxisSettings.grid.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxPolarChartOptions.commonAxisSettings.grid.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    },
    minorGrid: {
      /**
      * @name dxPolarChartOptions.commonAxisSettings.minorGrid.visible
      * @type boolean
      * @default true
      */
      visible: true,

      /**
      * @name dxPolarChartOptions.commonAxisSettings.minorGrid.color
      * @type string
      * @default '#d3d3d3'
      */
      color: '#d3d3d3',

      /**
      * @name dxPolarChartOptions.commonAxisSettings.minorGrid.width
      * @type number
      * @default 1
      */
      width: 1,

      /**
      * @name dxPolarChartOptions.commonAxisSettings.minorGrid.opacity
      * @type number
      * @default undefined
      */
      opacity: undefined
    },
    tick: {
      visible: true,
      color: '#767676',
      opacity: undefined,
      width: 1,
      length: 7
    },
    minorTick: {
      visible: false,
      color: '#767676',
      opacity: 0.3,
      width: 1,
      length: 7
    },
    stripStyle: {
      label: {
        font: {
          family: undefined,
          weight: 400,
          color: '#767676',
          size: 12,
          opacity: undefined
        }
      }
    },
    constantLineStyle: {
      width: 1,
      dashStyle: 'solid',
      color: '#000000',
      label: {
        visible: true,
        font: {
          family: undefined,
          weight: 400,
          color: '#767676',
          size: 12,
          opacity: undefined
        }
      }
    },
    inverted: false,
    allowDecimals: undefined,
    endOnTick: undefined
  },
  argumentAxis: {
    startAngle: 0,
    firstPointOnStartAngle: false,
    period: 0,
    originValue: undefined,
    tickInterval: {},
    minorTickInterval: {},
    minorTickCount: undefined,
    label: {
      customizeText: undefined,
      customizeHint: undefined,
      format: ''
    },
    strips: [{
      startValue: undefined,
      endValue: undefined,
      color: undefined,
      label: {
        text: undefined
      }
    }],
    constantLines: [{
      value: undefined,
      displayBehindSeries: false,
      extendAxis: false,
      label: {
        text: undefined
      }
    }],
    axisDivisionFactor: 50,
    categories: [],
    type: undefined,
    logarithmBase: 10,
    linearThreshold: undefined,
    argumentType: undefined,
    hoverMode: 'none',
    tick: {
      shift: 3
    },
    minorTick: {
      shift: 3
    }
  },
  valueAxis: {
    showZero: undefined,
    tickInterval: {},
    minorTickInterval: {},
    minorTickCount: undefined,
    tick: {
      visible: false
    },
    label: {
      customizeText: undefined,
      customizeHint: undefined,
      format: ''
    },
    strips: [{
      startValue: undefined,
      endValue: undefined,
      color: undefined,
      label: {
        text: undefined
      }
    }],
    constantLines: [{
      value: undefined,
      displayBehindSeries: false,
      extendAxis: false,
      label: {
        text: undefined
      }
    }],
    visualRange: undefined,
    wholeRange: undefined,
    visualRangeUpdateMode: "auto",
    minVisualRangeLength: undefined,
    minValueMargin: 0,
    maxValueMargin: 0,
    valueMarginsEnabled: true,
    axisDivisionFactor: 30,
    categories: [],
    type: undefined,
    logarithmBase: 10,
    linearThreshold: undefined,
    valueType: undefined,
    endOnTick: false
  },
  tooltip: {
    shared: false,
    interactive: false
  },
  commonAnnotationSettings: undefined,
  annotations: [{}],
  customizeAnnotation: undefined,
  onSeriesHoverChanged: function onSeriesHoverChanged() {},
  onSeriesSelectionChanged: function onSeriesSelectionChanged() {},
  series: undefined,
  onZoomStart: function onZoomStart() {},
  onZoomEnd: function onZoomEnd() {},
  resetVisualRange: function resetVisualRange() {},
  getValueAxis: function getValueAxis() {}
};
var BaseChart = {
  onDone: function onDone() {},
  onTooltipShown: function onTooltipShown() {},
  onTooltipHidden: function onTooltipHidden() {},
  pointSelectionMode: 'single',
  animation: {
    /**
    * @name BaseChartOptions.animation.enabled
    * @type boolean
    * @default true
    */
    enabled: true,

    /**
    * @name BaseChartOptions.animation.duration
    * @type number
    * @default 1000
    */
    duration: 1000,

    /**
    * @name BaseChartOptions.animation.easing
    * @type Enums.VizAnimationEasing
    * @default 'easeOutCubic'
    */
    easing: 'easeOutCubic',

    /**
    * @name BaseChartOptions.animation.maxPointCountSupported
    * @type number
    * @default 300
    */
    maxPointCountSupported: 300
  },
  tooltip: {
    customizeTooltip: undefined,
    contentTemplate: undefined,
    argumentFormat: '',
    shared: false,
    interactive: false
  },
  onPointClick: function onPointClick() {},
  onPointSelectionChanged: function onPointSelectionChanged() {},
  onPointHoverChanged: function onPointHoverChanged() {},
  dataSource: undefined,
  palette: [],
  paletteExtensionMode: 'blend',
  legend: {
    customizeItems: undefined,
    markerTemplate: undefined
  },
  series: [{}],
  customizePoint: undefined,
  customizeLabel: undefined,
  clearSelection: function clearSelection() {},
  hideTooltip: function hideTooltip() {},
  render: function render(renderOptions) {},
  refresh: function refresh() {},
  getAllSeries: function getAllSeries() {},
  getSeriesByName: function getSeriesByName() {},
  getSeriesByPos: function getSeriesByPos() {},
  adaptiveLayout: {
    width: 80,
    height: 80,
    keepLabels: true
  }
};
/**
* @name BaseChartAnnotationConfig
* @type object
* @inherits BaseWidgetAnnotationConfig
*/

var BaseChartAnnotationConfig = {
  argument: undefined,
  value: undefined,
  series: undefined
};
/**
* @name dxChartCommonAnnotationConfig
* @type object
* @inherits BaseChartAnnotationConfig
*/

var dxChartCommonAnnotationConfig = {
  axis: undefined,
  customizeTooltip: undefined,
  tooltipTemplate: undefined,
  template: undefined
};
/**
* @name dxChartAnnotationConfig
* @type object
* @inherits dxChartCommonAnnotationConfig
*/

var dxChartAnnotationConfig = {
  name: undefined
};
/**
* @name dxPolarChartCommonAnnotationConfig
* @type object
* @inherits BaseChartAnnotationConfig
*/

var dxPolarChartCommonAnnotationConfig = {
  radius: undefined,
  angle: undefined,
  customizeTooltip: undefined,
  tooltipTemplate: undefined,
  template: undefined
};
/**
* @name dxPolarChartAnnotationConfig
* @type object
* @inherits dxPolarChartCommonAnnotationConfig
*/

var dxPolarChartAnnotationConfig = {
  name: undefined
};
/**
* @name dxPieChartCommonAnnotationConfig
* @type object
* @inherits BaseWidgetAnnotationConfig
*/

var dxPieChartCommonAnnotationConfig = {
  argument: undefined,
  series: undefined,
  location: 'center',
  customizeTooltip: undefined,
  tooltipTemplate: undefined,
  template: undefined
};
/**
* @name dxPieChartAnnotationConfig
* @type object
* @inherits dxPieChartCommonAnnotationConfig
*/

var dxPieChartAnnotationConfig = {
  name: undefined
};