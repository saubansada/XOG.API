(function () {
  function _get() { if (typeof Reflect !== "undefined" && Reflect.get) { _get = Reflect.get.bind(); } else { _get = function _get(target, property, receiver) { var base = _superPropBase(target, property); if (!base) return; var desc = Object.getOwnPropertyDescriptor(base, property); if (desc.get) { return desc.get.call(arguments.length < 3 ? target : receiver); } return desc.value; }; } return _get.apply(this, arguments); }

  function _superPropBase(object, property) { while (!Object.prototype.hasOwnProperty.call(object, property)) { object = _getPrototypeOf(object); if (object === null) break; } return object; }

  function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function"); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, writable: true, configurable: true } }); Object.defineProperty(subClass, "prototype", { writable: false }); if (superClass) _setPrototypeOf(subClass, superClass); }

  function _setPrototypeOf(o, p) { _setPrototypeOf = Object.setPrototypeOf ? Object.setPrototypeOf.bind() : function _setPrototypeOf(o, p) { o.__proto__ = p; return o; }; return _setPrototypeOf(o, p); }

  function _createSuper(Derived) { var hasNativeReflectConstruct = _isNativeReflectConstruct(); return function _createSuperInternal() { var Super = _getPrototypeOf(Derived), result; if (hasNativeReflectConstruct) { var NewTarget = _getPrototypeOf(this).constructor; result = Reflect.construct(Super, arguments, NewTarget); } else { result = Super.apply(this, arguments); } return _possibleConstructorReturn(this, result); }; }

  function _possibleConstructorReturn(self, call) { if (call && (typeof call === "object" || typeof call === "function")) { return call; } else if (call !== void 0) { throw new TypeError("Derived constructors may only return object or undefined"); } return _assertThisInitialized(self); }

  function _assertThisInitialized(self) { if (self === void 0) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return self; }

  function _isNativeReflectConstruct() { if (typeof Reflect === "undefined" || !Reflect.construct) return false; if (Reflect.construct.sham) return false; if (typeof Proxy === "function") return true; try { Boolean.prototype.valueOf.call(Reflect.construct(Boolean, [], function () {})); return true; } catch (e) { return false; } }

  function _getPrototypeOf(o) { _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf.bind() : function _getPrototypeOf(o) { return o.__proto__ || Object.getPrototypeOf(o); }; return _getPrototypeOf(o); }

  function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, _toPropertyKey(descriptor.key), descriptor); } }

  function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); Object.defineProperty(Constructor, "prototype", { writable: false }); return Constructor; }

  function _toPropertyKey(arg) { var key = _toPrimitive(arg, "string"); return typeof key === "symbol" ? key : String(key); }

  function _toPrimitive(input, hint) { if (typeof input !== "object" || input === null) return input; var prim = input[Symbol.toPrimitive]; if (prim !== undefined) { var res = prim.call(input, hint || "default"); if (typeof res !== "object") return res; throw new TypeError("@@toPrimitive must return a primitive value."); } return (hint === "string" ? String : Number)(input); }

  function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

  (self["webpackChunkxog_ui"] = self["webpackChunkxog_ui"] || []).push([["main"], {
    /***/
    98255:
    /*!*******************************************************!*\
      !*** ./$_lazy_route_resources/ lazy namespace object ***!
      \*******************************************************/

    /***/
    function _(module) {
      function webpackEmptyAsyncContext(req) {
        // Here Promise.resolve().then() is used instead of new Promise() to prevent
        // uncaught exception popping up in devtools
        return Promise.resolve().then(function () {
          var e = new Error("Cannot find module '" + req + "'");
          e.code = 'MODULE_NOT_FOUND';
          throw e;
        });
      }

      webpackEmptyAsyncContext.keys = function () {
        return [];
      };

      webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
      webpackEmptyAsyncContext.id = 98255;
      module.exports = webpackEmptyAsyncContext;
      /***/
    },

    /***/
    90158:
    /*!***************************************!*\
      !*** ./src/app/app-routing.module.ts ***!
      \***************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "AppRoutingModule": function AppRoutingModule() {
          return (
            /* binding */
            _AppRoutingModule
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _auth_logout_logout_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./auth/logout/logout.component */
      28564);
      /* harmony import */


      var _auth_helpers_role_guard__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ./auth/_helpers/role.guard */
      9757);
      /* harmony import */


      var _auth_models_role__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! ./auth/_models/role */
      94621);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var routes = [{
        path: '',
        loadChildren: function loadChildren() {
          return src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.isDesktop ? Promise.all(
          /*! import() */
          [__webpack_require__.e("default-node_modules_rxjs__esm2015_internal_operators_debounceTime_js-src_app_models_address_-e52fb6"), __webpack_require__.e("src_app_desktop_desktop_module_ts")]).then(__webpack_require__.bind(__webpack_require__,
          /*! ./desktop/desktop.module */
          45638)).then(function (m) {
            return m.DesktopModule;
          }) : Promise.all(
          /*! import() */
          [__webpack_require__.e("default-node_modules_rxjs__esm2015_internal_operators_debounceTime_js-src_app_models_address_-e52fb6"), __webpack_require__.e("src_app_mobile_mobile_module_ts")]).then(__webpack_require__.bind(__webpack_require__,
          /*! ./mobile/mobile.module */
          69839)).then(function (m) {
            return m.MobileModule;
          });
        }
      }, {
        path: 'logout',
        component: _auth_logout_logout_component__WEBPACK_IMPORTED_MODULE_1__.LogoutComponent,
        canActivate: [_auth_helpers_role_guard__WEBPACK_IMPORTED_MODULE_2__.RoleGuardService],
        data: {
          roles: [_auth_models_role__WEBPACK_IMPORTED_MODULE_3__.Role.User]
        }
      }];

      var _AppRoutingModule = /*#__PURE__*/_createClass(function _AppRoutingModule() {
        _classCallCheck(this, _AppRoutingModule);
      });

      _AppRoutingModule.ɵfac = function AppRoutingModule_Factory(t) {
        return new (t || _AppRoutingModule)();
      };

      _AppRoutingModule.ɵmod = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineNgModule"]({
        type: _AppRoutingModule
      });
      _AppRoutingModule.ɵinj = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjector"]({
        imports: [[_angular_router__WEBPACK_IMPORTED_MODULE_5__.RouterModule.forRoot(routes, {
          onSameUrlNavigation: 'reload'
        })], _angular_router__WEBPACK_IMPORTED_MODULE_5__.RouterModule]
      });

      (function () {
        (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵsetNgModuleScope"](_AppRoutingModule, {
          imports: [_angular_router__WEBPACK_IMPORTED_MODULE_5__.RouterModule],
          exports: [_angular_router__WEBPACK_IMPORTED_MODULE_5__.RouterModule]
        });
      })();
      /***/

    },

    /***/
    55041:
    /*!**********************************!*\
      !*** ./src/app/app.component.ts ***!
      \**********************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "AppComponent": function AppComponent() {
          return (
            /* binding */
            _AppComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_fiire_cloud_messaging_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./services/fiire-cloud-messaging-service */
      39672);
      /* harmony import */


      var _services_api_services_notification_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ./services/api-services/notification.service */
      91294);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/router */
      39895);

      console.log("registring message");

      var _AppComponent = /*#__PURE__*/function () {
        function _AppComponent(messagingService, notificationMessageService) {
          _classCallCheck(this, _AppComponent);

          this.messagingService = messagingService;
          this.notificationMessageService = notificationMessageService;
          this.title = 'xog-ui';
        }

        _createClass(_AppComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {
            this.messagingService.requestPermission();
            this.messagingService.receiveMessage();
            this.message = this.messagingService.currentMessage;
            this.notificationMessageService.startFetchningNotifications();

            if (src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.isMobileApp) {}
          }
        }]);

        return _AppComponent;
      }();

      _AppComponent.ɵfac = function AppComponent_Factory(t) {
        return new (t || _AppComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services_fiire_cloud_messaging_service__WEBPACK_IMPORTED_MODULE_1__.FireCloudMessagingService), _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdirectiveInject"](_services_api_services_notification_service__WEBPACK_IMPORTED_MODULE_2__.NotificationMessageService));
      };

      _AppComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵdefineComponent"]({
        type: _AppComponent,
        selectors: [["app-root"]],
        decls: 1,
        vars: 0,
        template: function AppComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_3__["ɵɵelement"](0, "router-outlet");
          }
        },
        directives: [_angular_router__WEBPACK_IMPORTED_MODULE_4__.RouterOutlet],
        styles: ["@font-face {\n  font-family: \"Material Icons\";\n  font-style: normal;\n  font-weight: 400;\n  font-display: block;\n  src: url('material-icons.woff2') format(\"woff2\"), url('material-icons.woff') format(\"woff\");\n}\n.material-icons[_ngcontent-%COMP%] {\n  font-family: \"Material Icons\";\n  font-weight: normal;\n  font-style: normal;\n  font-size: 24px;\n  line-height: 1;\n  letter-spacing: normal;\n  text-transform: none;\n  display: inline-block;\n  white-space: nowrap;\n  word-wrap: normal;\n  direction: ltr;\n  -webkit-font-smoothing: antialiased;\n  -moz-osx-font-smoothing: grayscale;\n  text-rendering: optimizeLegibility;\n  font-feature-settings: \"liga\";\n}\n@font-face {\n  font-family: \"Material Icons Outlined\";\n  font-style: normal;\n  font-weight: 400;\n  font-display: block;\n  src: url('material-icons-outlined.woff2') format(\"woff2\"), url('material-icons-outlined.woff') format(\"woff\");\n}\n.material-icons-outlined[_ngcontent-%COMP%] {\n  font-family: \"Material Icons Outlined\";\n  font-weight: normal;\n  font-style: normal;\n  font-size: 24px;\n  line-height: 1;\n  letter-spacing: normal;\n  text-transform: none;\n  display: inline-block;\n  white-space: nowrap;\n  word-wrap: normal;\n  direction: ltr;\n  -webkit-font-smoothing: antialiased;\n  -moz-osx-font-smoothing: grayscale;\n  text-rendering: optimizeLegibility;\n  font-feature-settings: \"liga\";\n}\n@font-face {\n  font-family: \"Material Icons Round\";\n  font-style: normal;\n  font-weight: 400;\n  font-display: block;\n  src: url('material-icons-round.woff2') format(\"woff2\"), url('material-icons-round.woff') format(\"woff\");\n}\n.material-icons-round[_ngcontent-%COMP%] {\n  font-family: \"Material Icons Round\";\n  font-weight: normal;\n  font-style: normal;\n  font-size: 24px;\n  line-height: 1;\n  letter-spacing: normal;\n  text-transform: none;\n  display: inline-block;\n  white-space: nowrap;\n  word-wrap: normal;\n  direction: ltr;\n  -webkit-font-smoothing: antialiased;\n  -moz-osx-font-smoothing: grayscale;\n  text-rendering: optimizeLegibility;\n  font-feature-settings: \"liga\";\n}\n@font-face {\n  font-family: \"Material Icons Sharp\";\n  font-style: normal;\n  font-weight: 400;\n  font-display: block;\n  src: url('material-icons-sharp.woff2') format(\"woff2\"), url('material-icons-sharp.woff') format(\"woff\");\n}\n.material-icons-sharp[_ngcontent-%COMP%] {\n  font-family: \"Material Icons Sharp\";\n  font-weight: normal;\n  font-style: normal;\n  font-size: 24px;\n  line-height: 1;\n  letter-spacing: normal;\n  text-transform: none;\n  display: inline-block;\n  white-space: nowrap;\n  word-wrap: normal;\n  direction: ltr;\n  -webkit-font-smoothing: antialiased;\n  -moz-osx-font-smoothing: grayscale;\n  text-rendering: optimizeLegibility;\n  font-feature-settings: \"liga\";\n}\n@font-face {\n  font-family: \"Material Icons Two Tone\";\n  font-style: normal;\n  font-weight: 400;\n  font-display: block;\n  src: url('material-icons-two-tone.woff2') format(\"woff2\"), url('material-icons-two-tone.woff') format(\"woff\");\n}\n.material-icons-two-tone[_ngcontent-%COMP%] {\n  font-family: \"Material Icons Two Tone\";\n  font-weight: normal;\n  font-style: normal;\n  font-size: 24px;\n  line-height: 1;\n  letter-spacing: normal;\n  text-transform: none;\n  display: inline-block;\n  white-space: nowrap;\n  word-wrap: normal;\n  direction: ltr;\n  -webkit-font-smoothing: antialiased;\n  -moz-osx-font-smoothing: grayscale;\n  text-rendering: optimizeLegibility;\n  font-feature-settings: \"liga\";\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uLy4uL25vZGVfbW9kdWxlcy9tYXRlcmlhbC1pY29ucy9pY29uZm9udC9tYXRlcmlhbC1pY29ucy5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDRSw2QkFBNkI7RUFDN0Isa0JBQWtCO0VBQ2xCLGdCQUFnQjtFQUNoQixtQkFBbUI7RUFDbkIsMkZBQStGO0FBQ2pHO0FBQ0E7RUFDRSw2QkFBNkI7RUFDN0IsbUJBQW1CO0VBQ25CLGtCQUFrQjtFQUNsQixlQUFlO0VBQ2YsY0FBYztFQUNkLHNCQUFzQjtFQUN0QixvQkFBb0I7RUFDcEIscUJBQXFCO0VBQ3JCLG1CQUFtQjtFQUNuQixpQkFBaUI7RUFDakIsY0FBYztFQUNkLG1DQUFtQztFQUNuQyxrQ0FBa0M7RUFDbEMsa0NBQWtDO0VBQ2xDLDZCQUE2QjtBQUMvQjtBQUVBO0VBQ0Usc0NBQXNDO0VBQ3RDLGtCQUFrQjtFQUNsQixnQkFBZ0I7RUFDaEIsbUJBQW1CO0VBQ25CLDZHQUFpSDtBQUNuSDtBQUNBO0VBQ0Usc0NBQXNDO0VBQ3RDLG1CQUFtQjtFQUNuQixrQkFBa0I7RUFDbEIsZUFBZTtFQUNmLGNBQWM7RUFDZCxzQkFBc0I7RUFDdEIsb0JBQW9CO0VBQ3BCLHFCQUFxQjtFQUNyQixtQkFBbUI7RUFDbkIsaUJBQWlCO0VBQ2pCLGNBQWM7RUFDZCxtQ0FBbUM7RUFDbkMsa0NBQWtDO0VBQ2xDLGtDQUFrQztFQUNsQyw2QkFBNkI7QUFDL0I7QUFFQTtFQUNFLG1DQUFtQztFQUNuQyxrQkFBa0I7RUFDbEIsZ0JBQWdCO0VBQ2hCLG1CQUFtQjtFQUNuQix1R0FBMkc7QUFDN0c7QUFDQTtFQUNFLG1DQUFtQztFQUNuQyxtQkFBbUI7RUFDbkIsa0JBQWtCO0VBQ2xCLGVBQWU7RUFDZixjQUFjO0VBQ2Qsc0JBQXNCO0VBQ3RCLG9CQUFvQjtFQUNwQixxQkFBcUI7RUFDckIsbUJBQW1CO0VBQ25CLGlCQUFpQjtFQUNqQixjQUFjO0VBQ2QsbUNBQW1DO0VBQ25DLGtDQUFrQztFQUNsQyxrQ0FBa0M7RUFDbEMsNkJBQTZCO0FBQy9CO0FBRUE7RUFDRSxtQ0FBbUM7RUFDbkMsa0JBQWtCO0VBQ2xCLGdCQUFnQjtFQUNoQixtQkFBbUI7RUFDbkIsdUdBQTJHO0FBQzdHO0FBQ0E7RUFDRSxtQ0FBbUM7RUFDbkMsbUJBQW1CO0VBQ25CLGtCQUFrQjtFQUNsQixlQUFlO0VBQ2YsY0FBYztFQUNkLHNCQUFzQjtFQUN0QixvQkFBb0I7RUFDcEIscUJBQXFCO0VBQ3JCLG1CQUFtQjtFQUNuQixpQkFBaUI7RUFDakIsY0FBYztFQUNkLG1DQUFtQztFQUNuQyxrQ0FBa0M7RUFDbEMsa0NBQWtDO0VBQ2xDLDZCQUE2QjtBQUMvQjtBQUVBO0VBQ0Usc0NBQXNDO0VBQ3RDLGtCQUFrQjtFQUNsQixnQkFBZ0I7RUFDaEIsbUJBQW1CO0VBQ25CLDZHQUFpSDtBQUNuSDtBQUNBO0VBQ0Usc0NBQXNDO0VBQ3RDLG1CQUFtQjtFQUNuQixrQkFBa0I7RUFDbEIsZUFBZTtFQUNmLGNBQWM7RUFDZCxzQkFBc0I7RUFDdEIsb0JBQW9CO0VBQ3BCLHFCQUFxQjtFQUNyQixtQkFBbUI7RUFDbkIsaUJBQWlCO0VBQ2pCLGNBQWM7RUFDZCxtQ0FBbUM7RUFDbkMsa0NBQWtDO0VBQ2xDLGtDQUFrQztFQUNsQyw2QkFBNkI7QUFDL0IiLCJmaWxlIjoiYXBwLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiQGZvbnQtZmFjZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zXCI7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1kaXNwbGF5OiBibG9jaztcbiAgc3JjOiB1cmwoXCIuL21hdGVyaWFsLWljb25zLndvZmYyXCIpIGZvcm1hdChcIndvZmYyXCIpLCB1cmwoXCIuL21hdGVyaWFsLWljb25zLndvZmZcIikgZm9ybWF0KFwid29mZlwiKTtcbn1cbi5tYXRlcmlhbC1pY29ucyB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zXCI7XG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsaW5lLWhlaWdodDogMTtcbiAgbGV0dGVyLXNwYWNpbmc6IG5vcm1hbDtcbiAgdGV4dC10cmFuc2Zvcm06IG5vbmU7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcbiAgd29yZC13cmFwOiBub3JtYWw7XG4gIGRpcmVjdGlvbjogbHRyO1xuICAtd2Via2l0LWZvbnQtc21vb3RoaW5nOiBhbnRpYWxpYXNlZDtcbiAgLW1vei1vc3gtZm9udC1zbW9vdGhpbmc6IGdyYXlzY2FsZTtcbiAgdGV4dC1yZW5kZXJpbmc6IG9wdGltaXplTGVnaWJpbGl0eTtcbiAgZm9udC1mZWF0dXJlLXNldHRpbmdzOiBcImxpZ2FcIjtcbn1cblxuQGZvbnQtZmFjZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIE91dGxpbmVkXCI7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1kaXNwbGF5OiBibG9jaztcbiAgc3JjOiB1cmwoXCIuL21hdGVyaWFsLWljb25zLW91dGxpbmVkLndvZmYyXCIpIGZvcm1hdChcIndvZmYyXCIpLCB1cmwoXCIuL21hdGVyaWFsLWljb25zLW91dGxpbmVkLndvZmZcIikgZm9ybWF0KFwid29mZlwiKTtcbn1cbi5tYXRlcmlhbC1pY29ucy1vdXRsaW5lZCB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIE91dGxpbmVkXCI7XG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsaW5lLWhlaWdodDogMTtcbiAgbGV0dGVyLXNwYWNpbmc6IG5vcm1hbDtcbiAgdGV4dC10cmFuc2Zvcm06IG5vbmU7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcbiAgd29yZC13cmFwOiBub3JtYWw7XG4gIGRpcmVjdGlvbjogbHRyO1xuICAtd2Via2l0LWZvbnQtc21vb3RoaW5nOiBhbnRpYWxpYXNlZDtcbiAgLW1vei1vc3gtZm9udC1zbW9vdGhpbmc6IGdyYXlzY2FsZTtcbiAgdGV4dC1yZW5kZXJpbmc6IG9wdGltaXplTGVnaWJpbGl0eTtcbiAgZm9udC1mZWF0dXJlLXNldHRpbmdzOiBcImxpZ2FcIjtcbn1cblxuQGZvbnQtZmFjZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFJvdW5kXCI7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1kaXNwbGF5OiBibG9jaztcbiAgc3JjOiB1cmwoXCIuL21hdGVyaWFsLWljb25zLXJvdW5kLndvZmYyXCIpIGZvcm1hdChcIndvZmYyXCIpLCB1cmwoXCIuL21hdGVyaWFsLWljb25zLXJvdW5kLndvZmZcIikgZm9ybWF0KFwid29mZlwiKTtcbn1cbi5tYXRlcmlhbC1pY29ucy1yb3VuZCB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFJvdW5kXCI7XG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsaW5lLWhlaWdodDogMTtcbiAgbGV0dGVyLXNwYWNpbmc6IG5vcm1hbDtcbiAgdGV4dC10cmFuc2Zvcm06IG5vbmU7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcbiAgd29yZC13cmFwOiBub3JtYWw7XG4gIGRpcmVjdGlvbjogbHRyO1xuICAtd2Via2l0LWZvbnQtc21vb3RoaW5nOiBhbnRpYWxpYXNlZDtcbiAgLW1vei1vc3gtZm9udC1zbW9vdGhpbmc6IGdyYXlzY2FsZTtcbiAgdGV4dC1yZW5kZXJpbmc6IG9wdGltaXplTGVnaWJpbGl0eTtcbiAgZm9udC1mZWF0dXJlLXNldHRpbmdzOiBcImxpZ2FcIjtcbn1cblxuQGZvbnQtZmFjZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFNoYXJwXCI7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1kaXNwbGF5OiBibG9jaztcbiAgc3JjOiB1cmwoXCIuL21hdGVyaWFsLWljb25zLXNoYXJwLndvZmYyXCIpIGZvcm1hdChcIndvZmYyXCIpLCB1cmwoXCIuL21hdGVyaWFsLWljb25zLXNoYXJwLndvZmZcIikgZm9ybWF0KFwid29mZlwiKTtcbn1cbi5tYXRlcmlhbC1pY29ucy1zaGFycCB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFNoYXJwXCI7XG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsaW5lLWhlaWdodDogMTtcbiAgbGV0dGVyLXNwYWNpbmc6IG5vcm1hbDtcbiAgdGV4dC10cmFuc2Zvcm06IG5vbmU7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcbiAgd29yZC13cmFwOiBub3JtYWw7XG4gIGRpcmVjdGlvbjogbHRyO1xuICAtd2Via2l0LWZvbnQtc21vb3RoaW5nOiBhbnRpYWxpYXNlZDtcbiAgLW1vei1vc3gtZm9udC1zbW9vdGhpbmc6IGdyYXlzY2FsZTtcbiAgdGV4dC1yZW5kZXJpbmc6IG9wdGltaXplTGVnaWJpbGl0eTtcbiAgZm9udC1mZWF0dXJlLXNldHRpbmdzOiBcImxpZ2FcIjtcbn1cblxuQGZvbnQtZmFjZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFR3byBUb25lXCI7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC13ZWlnaHQ6IDQwMDtcbiAgZm9udC1kaXNwbGF5OiBibG9jaztcbiAgc3JjOiB1cmwoXCIuL21hdGVyaWFsLWljb25zLXR3by10b25lLndvZmYyXCIpIGZvcm1hdChcIndvZmYyXCIpLCB1cmwoXCIuL21hdGVyaWFsLWljb25zLXR3by10b25lLndvZmZcIikgZm9ybWF0KFwid29mZlwiKTtcbn1cbi5tYXRlcmlhbC1pY29ucy10d28tdG9uZSB7XG4gIGZvbnQtZmFtaWx5OiBcIk1hdGVyaWFsIEljb25zIFR3byBUb25lXCI7XG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XG4gIGZvbnQtc3R5bGU6IG5vcm1hbDtcbiAgZm9udC1zaXplOiAyNHB4O1xuICBsaW5lLWhlaWdodDogMTtcbiAgbGV0dGVyLXNwYWNpbmc6IG5vcm1hbDtcbiAgdGV4dC10cmFuc2Zvcm06IG5vbmU7XG4gIGRpc3BsYXk6IGlubGluZS1ibG9jaztcbiAgd2hpdGUtc3BhY2U6IG5vd3JhcDtcbiAgd29yZC13cmFwOiBub3JtYWw7XG4gIGRpcmVjdGlvbjogbHRyO1xuICAtd2Via2l0LWZvbnQtc21vb3RoaW5nOiBhbnRpYWxpYXNlZDtcbiAgLW1vei1vc3gtZm9udC1zbW9vdGhpbmc6IGdyYXlzY2FsZTtcbiAgdGV4dC1yZW5kZXJpbmc6IG9wdGltaXplTGVnaWJpbGl0eTtcbiAgZm9udC1mZWF0dXJlLXNldHRpbmdzOiBcImxpZ2FcIjtcbn1cbiJdfQ== */"]
      });
      /***/
    },

    /***/
    36747:
    /*!*******************************!*\
      !*** ./src/app/app.module.ts ***!
      \*******************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "MyUrlSerializer": function MyUrlSerializer() {
          return (
            /* binding */
            _MyUrlSerializer
          );
        },

        /* harmony export */
        "AppModule": function AppModule() {
          return (
            /* binding */
            _AppModule
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(
      /*! @angular/platform-browser */
      39075);
      /* harmony import */


      var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(
      /*! @angular/platform-browser/animations */
      75835);
      /* harmony import */


      var _app_routing_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ./app-routing.module */
      90158);
      /* harmony import */


      var _app_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./app.component */
      55041);
      /* harmony import */


      var _shared_shared_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ./shared/shared.module */
      44466);
      /* harmony import */


      var _angular_common_http__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(
      /*! @angular/common/http */
      91841);
      /* harmony import */


      var _auth_helpers_jwt_interceptor__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! ./auth/_helpers/jwt.interceptor */
      14778);
      /* harmony import */


      var _auth_helpers_error_interceptor__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! ./auth/_helpers/error.interceptor */
      761);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var _environments_environment__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! ../environments/environment */
      92340);
      /* harmony import */


      var _angular_fire_compat__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(
      /*! @angular/fire/compat */
      88939);
      /* harmony import */


      var _angular_fire_compat_messaging__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(
      /*! @angular/fire/compat/messaging */
      52577);
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(
      /*! @angular/common */
      38583);
      /* harmony import */


      var _services_fiire_cloud_messaging_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(
      /*! ./services/fiire-cloud-messaging-service */
      39672);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _MyUrlSerializer = /*#__PURE__*/function (_angular_router__WEBP) {
        _inherits(_MyUrlSerializer, _angular_router__WEBP);

        var _super = _createSuper(_MyUrlSerializer);

        function _MyUrlSerializer() {
          _classCallCheck(this, _MyUrlSerializer);

          return _super.apply(this, arguments);
        }

        _createClass(_MyUrlSerializer, [{
          key: "serialize",
          value: function serialize(tree) {
            var url = _get(_getPrototypeOf(_MyUrlSerializer.prototype), "serialize", this).call(this, tree).replace(/\(|\)|\w+-\w+:/g, '');

            if (url.indexOf('action:') > -1) {
              url = (url.split('action:')[0] + '/' + url.split('action:')[1]).replace('//', '/');
            }

            return url;
          }
        }]);

        return _MyUrlSerializer;
      }(_angular_router__WEBPACK_IMPORTED_MODULE_7__.DefaultUrlSerializer);

      var _AppModule = /*#__PURE__*/function () {
        function _AppModule() {
          _classCallCheck(this, _AppModule);

          _environments_environment__WEBPACK_IMPORTED_MODULE_5__.environment.isDesktop = !this.isMobile();
          var isApp = localStorage.getItem("IsApp") === "yes";

          if (isApp) {
            _environments_environment__WEBPACK_IMPORTED_MODULE_5__.environment.isMobileApp = true;
          }
        }

        _createClass(_AppModule, [{
          key: "isMobile",
          value: function isMobile() {
            if (navigator.userAgent.match(/Android/i) || navigator.userAgent.match(/webOS/i) || navigator.userAgent.match(/iPhone/i) || navigator.userAgent.match(/iPod/i) || navigator.userAgent.match(/BlackBerry/i) || navigator.userAgent.match(/Windows Phone/i)) {
              return true;
            } else {
              return false;
            }
          }
        }]);

        return _AppModule;
      }();

      _AppModule.ɵfac = function AppModule_Factory(t) {
        return new (t || _AppModule)();
      };

      _AppModule.ɵmod = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdefineNgModule"]({
        type: _AppModule,
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent]
      });
      _AppModule.ɵinj = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵdefineInjector"]({
        providers: [{
          provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_9__.HTTP_INTERCEPTORS,
          useClass: _auth_helpers_jwt_interceptor__WEBPACK_IMPORTED_MODULE_3__.JwtInterceptor,
          multi: true
        }, {
          provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_9__.HTTP_INTERCEPTORS,
          useClass: _auth_helpers_error_interceptor__WEBPACK_IMPORTED_MODULE_4__.ErrorInterceptor,
          multi: true
        }, {
          provide: _angular_router__WEBPACK_IMPORTED_MODULE_7__.UrlSerializer,
          useClass: _MyUrlSerializer
        }, _services_fiire_cloud_messaging_service__WEBPACK_IMPORTED_MODULE_6__.FireCloudMessagingService, _angular_common__WEBPACK_IMPORTED_MODULE_10__.AsyncPipe],
        imports: [[_angular_platform_browser__WEBPACK_IMPORTED_MODULE_11__.BrowserModule, _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_12__.BrowserAnimationsModule, _app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule, _shared_shared_module__WEBPACK_IMPORTED_MODULE_2__.SharedModule, _angular_fire_compat_messaging__WEBPACK_IMPORTED_MODULE_13__.AngularFireMessagingModule, _angular_fire_compat__WEBPACK_IMPORTED_MODULE_14__.AngularFireModule.initializeApp(_environments_environment__WEBPACK_IMPORTED_MODULE_5__.environment.firebaseConfig)]]
      });

      (function () {
        (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_8__["ɵɵsetNgModuleScope"](_AppModule, {
          declarations: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent],
          imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_11__.BrowserModule, _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_12__.BrowserAnimationsModule, _app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule, _shared_shared_module__WEBPACK_IMPORTED_MODULE_2__.SharedModule, _angular_fire_compat_messaging__WEBPACK_IMPORTED_MODULE_13__.AngularFireMessagingModule, _angular_fire_compat__WEBPACK_IMPORTED_MODULE_14__.AngularFireModule]
        });
      })();
      /***/

    },

    /***/
    761:
    /*!****************************************************!*\
      !*** ./src/app/auth/_helpers/error.interceptor.ts ***!
      \****************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "ErrorInterceptor": function ErrorInterceptor() {
          return (
            /* binding */
            _ErrorInterceptor
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! rxjs */
      25917);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! rxjs/operators */
      5304);
      /* harmony import */


      var src_app_models_common__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/app/models/common */
      71987);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_authentication_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ../_services/authentication.service */
      7893);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var src_app_shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! src/app/shared/services/error-interceptor.service */
      95731);

      var _ErrorInterceptor = /*#__PURE__*/function () {
        function _ErrorInterceptor(authenticationService, _router, errorIntrcptr) {
          _classCallCheck(this, _ErrorInterceptor);

          this.authenticationService = authenticationService;
          this._router = _router;
          this.errorIntrcptr = errorIntrcptr;
        }

        _createClass(_ErrorInterceptor, [{
          key: "intercept",
          value: function intercept(request, next) {
            return next.handle(request).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.catchError)(this.handleError()));
          }
        }, {
          key: "handleError",
          value: function handleError() {
            var _this = this;

            var operation = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 'operation';
            var result = arguments.length > 1 ? arguments[1] : undefined;
            return function (response) {
              if (response.status === 401) {
                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: "Please login to continue..",
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Unauthorized,
                  Data: {
                    callback: function callback() {
                      if (src_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.isDesktop) {
                        _this._router.navigateByUrl("");

                        _this.authenticationService.logout().subscribe(function () {
                          _this._router.navigateByUrl("/login");
                        });
                      } else {
                        _this._router.navigateByUrl("");

                        _this.authenticationService.logout().subscribe(function () {
                          _this._router.navigateByUrl("/login");
                        });
                      }
                    }
                  }
                });
              } else if (response.status == 400) {
                var msg = response.error.Message;

                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: msg,
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Failure,
                  Data: response
                });
              } else if (response.status == 500) {
                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: "Error processing your request",
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Error,
                  Data: response
                });
              } else if (response.status == 404) {
                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: "Requested service could not be found",
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.NotFound,
                  Data: response
                });
              } else if (response.status == 0) {
                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: "Error processing your request",
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Failure,
                  Data: response
                });

                _this._router.navigateByUrl("/server-down");
              } else {
                _this.errorIntrcptr.httpErrorOccurred.next({
                  Message: "Unknown Error",
                  Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Error,
                  Data: response
                });
              }

              if (!src_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.production) {
                console.log("".concat(operation, " failed: ").concat(response.message));
              }

              return (0, rxjs__WEBPACK_IMPORTED_MODULE_5__.of)(result);
            };
          }
        }]);

        return _ErrorInterceptor;
      }();

      _ErrorInterceptor.ɵfac = function ErrorInterceptor_Factory(t) {
        return new (t || _ErrorInterceptor)(_angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_2__.AuthenticationService), _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵinject"](_angular_router__WEBPACK_IMPORTED_MODULE_7__.Router), _angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵinject"](src_app_shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_3__.ErrorInterceptorService));
      };

      _ErrorInterceptor.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_6__["ɵɵdefineInjectable"]({
        token: _ErrorInterceptor,
        factory: _ErrorInterceptor.ɵfac
      });
      /***/
    },

    /***/
    14778:
    /*!**************************************************!*\
      !*** ./src/app/auth/_helpers/jwt.interceptor.ts ***!
      \**************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "JwtInterceptor": function JwtInterceptor() {
          return (
            /* binding */
            _JwtInterceptor
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_authentication_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ../_services/authentication.service */
      7893);

      var _JwtInterceptor = /*#__PURE__*/function () {
        function _JwtInterceptor(authenticationService) {
          _classCallCheck(this, _JwtInterceptor);

          this.authenticationService = authenticationService;
        }

        _createClass(_JwtInterceptor, [{
          key: "intercept",
          value: function intercept(request, next) {
            if (request.url.indexOf("https://atlas.microsoft.com") > -1) {
              request = request.clone({
                setHeaders: {
                  Authorization: "Bearer ".concat(src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.azureAuthorization)
                }
              });
            } else if (request.url.indexOf("token") < 0) {
              var currentUser = this.authenticationService.currentUserValue;

              if (currentUser && currentUser.access_token) {
                request = request.clone({
                  setHeaders: {
                    Authorization: "Bearer ".concat(currentUser.access_token)
                  }
                });
              }
            } else {
              // ${currentUser.token}`,
              request = request.clone({
                setHeaders: {
                  "Content-Type": "application/x-www-form-urlencoded;charset=utf-8" // 'Access-Control-Allow-Origin': '*',
                  //"Accept": "*/*"

                }
              });
            }

            return next.handle(request);
          }
        }]);

        return _JwtInterceptor;
      }();

      _JwtInterceptor.ɵfac = function JwtInterceptor_Factory(t) {
        return new (t || _JwtInterceptor)(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_1__.AuthenticationService));
      };

      _JwtInterceptor.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineInjectable"]({
        token: _JwtInterceptor,
        factory: _JwtInterceptor.ɵfac
      });
      /***/
    },

    /***/
    9757:
    /*!*********************************************!*\
      !*** ./src/app/auth/_helpers/role.guard.ts ***!
      \*********************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "RoleGuardService": function RoleGuardService() {
          return (
            /* binding */
            _RoleGuardService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_authentication_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../_services/authentication.service */
      7893);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/router */
      39895);

      var _RoleGuardService = /*#__PURE__*/function () {
        function _RoleGuardService(_authService, _router) {
          _classCallCheck(this, _RoleGuardService);

          this._authService = _authService;
          this._router = _router;
        }

        _createClass(_RoleGuardService, [{
          key: "canActivate",
          value: function canActivate(next, state) {
            var _a;

            var currentUser = this._authService.currentUserValue;
            var res = false;
            var isVerifiedUser = this._authService.isUserLoggedIn;

            if (currentUser != null && next.data.roles === undefined) {
              res = true;
            } else if (isVerifiedUser) {
              var userRoles = ((_a = currentUser.roles) !== null && _a !== void 0 ? _a : "").split(",");
              res = next.data.roles && next.data.roles.some(function (ai) {
                return userRoles.includes(ai);
              });
            }

            if (res == false) {
              this._router.navigate(['/login']);
            }

            return res;
          }
        }]);

        return _RoleGuardService;
      }();

      _RoleGuardService.ɵfac = function RoleGuardService_Factory(t) {
        return new (t || _RoleGuardService)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_0__.AuthenticationService), _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_angular_router__WEBPACK_IMPORTED_MODULE_2__.Router));
      };

      _RoleGuardService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({
        token: _RoleGuardService,
        factory: _RoleGuardService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    94621:
    /*!**************************************!*\
      !*** ./src/app/auth/_models/role.ts ***!
      \**************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "Role": function Role() {
          return (
            /* binding */
            _Role
          );
        }
        /* harmony export */

      });

      var _Role;

      (function (Role) {
        Role["Admin"] = "Admin";
        Role["User"] = "User";
      })(_Role || (_Role = {}));
      /***/

    },

    /***/
    7893:
    /*!**********************************************************!*\
      !*** ./src/app/auth/_services/authentication.service.ts ***!
      \**********************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "AuthenticationService": function AuthenticationService() {
          return (
            /* binding */
            _AuthenticationService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/common/http */
      91841);
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! rxjs */
      26215);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! rxjs/operators */
      88002);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _AuthenticationService = /*#__PURE__*/function () {
        function _AuthenticationService(http) {
          _classCallCheck(this, _AuthenticationService);

          this.http = http;
          var obj = localStorage.getItem('currentUser');
          this.currentUserSubject = new rxjs__WEBPACK_IMPORTED_MODULE_1__.BehaviorSubject(obj != null ? JSON.parse(obj) : null);
          this.currentUser = this.currentUserSubject.asObservable();
        }

        _createClass(_AuthenticationService, [{
          key: "currentUserValue",
          get: function get() {
            return this.currentUserSubject.value;
          }
        }, {
          key: "isUserLoggedIn",
          get: function get() {
            return this.currentUserValue != null && this.currentUserValue.requireOTP == 'False';
          }
        }, {
          key: "login",
          value: function login(username, password) {
            var _this2 = this;

            var myheader = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded');
            var body = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpParams();
            body = body.set('UserName', username);
            body = body.set('Password', password);
            body = body.set('grant_type', "password");
            return this.http.post("".concat(src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.appAuthUrl), body, {
              headers: myheader
            }).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.map)(function (user) {
              localStorage.setItem('currentUser', JSON.stringify(user));

              _this2.currentUserSubject.next(user);

              return user;
            }));
          }
        }, {
          key: "updateRequireOTP",
          value: function updateRequireOTP(res) {
            var user = this.currentUserValue;
            user.requireOTP = res ? "True" : "False";
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
          }
        }, {
          key: "signup",
          value: function signup(fullName, phoneNumber, username, password, confirm) {
            var _this3 = this;

            return this.http.post("".concat(src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl, "auth/register"), {
              "Aadhar": "",
              "Address": "",
              "FullName": fullName,
              "PhoneNumber": phoneNumber,
              "Email": username,
              "Password": password,
              "ConfirmPassword": confirm
            }).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.map)(function (user) {
              localStorage.setItem('currentUser', JSON.stringify(user));

              _this3.currentUserSubject.next(user);

              return user;
            }));
          }
        }, {
          key: "logout",
          value: function logout() {
            var _this4 = this;

            var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl;
            return this.http.post("".concat(url, "auth/logout"), null).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.map)(function (user) {
              localStorage.removeItem('currentUser');

              _this4.currentUserSubject.next(null);

              return user;
            }));
          }
        }]);

        return _AuthenticationService;
      }();

      _AuthenticationService.ɵfac = function AuthenticationService_Factory(t) {
        return new (t || _AuthenticationService)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient));
      };

      _AuthenticationService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjectable"]({
        token: _AuthenticationService,
        factory: _AuthenticationService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    4903:
    /*!************************************************!*\
      !*** ./src/app/auth/_services/user.service.ts ***!
      \************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "UserService": function UserService() {
          return (
            /* binding */
            _UserService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../../../environments/environment */
      92340);
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! rxjs */
      25917);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! rxjs/operators */
      88002);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var src_app_services_api_services_api_request_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! src/app/services/api-services/api-request.service */
      98424); // '../../src/environments/environment';


      var _UserService = /*#__PURE__*/function () {
        function _UserService(apiService) {
          _classCallCheck(this, _UserService);

          this.apiService = apiService;
        }

        _createClass(_UserService, [{
          key: "getCurrentUserDetails",
          value: function getCurrentUserDetails(forceLoad) {
            if (forceLoad || JSON.parse(localStorage.getItem("userDetails")) == null) {
              return this.apiService.get("".concat(_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl, "user/get/current")).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_2__.map)(function (res) {
                localStorage.setItem("userDetails", JSON.stringify(res.Data));
                return res.Data;
              }));
            } else {
              return (0, rxjs__WEBPACK_IMPORTED_MODULE_3__.of)(JSON.parse(localStorage.getItem("userDetails")));
            }
          }
        }, {
          key: "saveUserDetails",
          value: function saveUserDetails(data) {
            return this.apiService.put("".concat(_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl, "user/edit"), data);
          }
        }]);

        return _UserService;
      }();

      _UserService.ɵfac = function UserService_Factory(t) {
        return new (t || _UserService)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](src_app_services_api_services_api_request_service__WEBPACK_IMPORTED_MODULE_1__.ApiRequestService));
      };

      _UserService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjectable"]({
        token: _UserService,
        factory: _UserService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    78146:
    /*!***********************************************!*\
      !*** ./src/app/auth/login/login.component.ts ***!
      \***********************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "LoginComponent": function LoginComponent() {
          return (
            /* binding */
            _LoginComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/forms */
      3679);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! rxjs/operators */
      28049);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! src/app/shared/base.component */
      87947);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_authentication_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ../_services/authentication.service */
      7893);

      var _LoginComponent = /*#__PURE__*/function (_src_app_shared_base_) {
        _inherits(_LoginComponent, _src_app_shared_base_);

        var _super2 = _createSuper(_LoginComponent);

        function _LoginComponent(injector, authenticationService) {
          var _this5;

          _classCallCheck(this, _LoginComponent);

          _this5 = _super2.call(this, injector);
          _this5.injector = injector;
          _this5.authenticationService = authenticationService;
          _this5.submitted = true;
          _this5.modalId = "login-modal";
          _this5.assetUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.assetsUrl;
          _this5.showPassword = false;
          _this5.formInstance = _this5.fb.group({
            UserName: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_3__.Validators.required]],
            Password: ['']
          });
          return _this5;
        }

        _createClass(_LoginComponent, [{
          key: "email",
          get: function get() {
            return this.formInstance.get('UserName');
          }
        }, {
          key: "password",
          get: function get() {
            return this.formInstance.get('Password');
          }
        }, {
          key: "visibility",
          value: function visibility() {
            this.showPassword = !this.showPassword;
          }
        }, {
          key: "ngOnInit",
          value: function ngOnInit() {
            var _this6 = this;

            this.showModal(this.modalId, function () {
              _this6.modalClose();
            });
          }
        }, {
          key: "modalClose",
          value: function modalClose() {
            if (this.router != null) {
              var outletUrls = [];

              if (this.router.url.indexOf('otp') >= 0) {
                outletUrls.push('otp');
              }

              this.router.navigate([{
                outlets: {
                  action: outletUrls,
                  primary: []
                }
              }]);
            }
          }
        }, {
          key: "submitForm",
          value: function submitForm() {
            var _this7 = this;

            var _a, _b, _c;

            this.submitted = true;

            if (this.formInstance.invalid) {
              return;
            }

            this.showFullSpinner();
            var pass = ((_a = this.password) === null || _a === void 0 ? void 0 : _a.value) == null ? '' : (_b = this.password) === null || _b === void 0 ? void 0 : _b.value;
            this.authenticationService.login((_c = this.email) === null || _c === void 0 ? void 0 : _c.value, pass).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.first)()).subscribe(function (user) {
              _this7.formInstance.reset();

              if (user.requireOTP == "True") {
                _this7.router.navigate([{
                  outlets: {
                    action: ["otp"],
                    primary: []
                  }
                }]);
              } else {}

              _this7.hideFullSpinner();
            }, function (error) {
              setTimeout(function () {
                _this7.hideFullSpinner();
              }, 500);
            });
          }
        }]);

        return _LoginComponent;
      }(src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_1__.BaseComponent);

      _LoginComponent.ɵfac = function LoginComponent_Factory(t) {
        return new (t || _LoginComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_5__.Injector), _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdirectiveInject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_2__.AuthenticationService));
      };

      _LoginComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdefineComponent"]({
        type: _LoginComponent,
        selectors: [["app-login"]],
        features: [_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵInheritDefinitionFeature"]],
        decls: 34,
        vars: 3,
        consts: [["id", "modal-container"], ["uk-modal", "", "container", "#modal-container", "bg-close", "false", "esc-close", "false", 3, "id"], [1, "uk-modal-dialog", "login-modal"], ["type", "button", "uk-close", "", 1, "uk-modal-close-default"], [1, "uk-modal-body"], [1, "login-title"], [1, "login-subtitle"], ["uk-grid", "", 1, "uk-grid-small", 3, "formGroup", "ngSubmit"], [1, "uk-width-1-1", "uk-margin-medium-top"], [1, "phone-label"], [1, "uk-inline", "uk-width-1-1"], [1, "uk-form-icon", "phone-code"], ["type", "number", "max-length", "10", "placeholder", "Enter your mobile number", 1, "uk-input", "phone-input", "uk-width-1-1", 3, "formControlName"], [1, "error-text"], [1, "material-icons-outlined", "uk-float-right"], [1, "uk-width-1-1"], ["type", "submit", 1, "uk-button", "phone-submit", "uk-width-1-1"], [1, "material-icons-outlined"], [1, "login-terms"], ["href", ""]],
        template: function LoginComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](0, "div", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](1, "div", 1);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](2, "div", 2);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](3, "button", 3);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](4, "div", 4);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](5, "p", 5);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](6, "Login/Sign Up");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](7, "p", 6);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](8, "Login with phone number");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](9, "form", 7);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵlistener"]("ngSubmit", function LoginComponent_Template_form_ngSubmit_9_listener() {
              return ctx.submitForm();
            });

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](10, "div", 8);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](11, "label", 9);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](12, "Phone number");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](13, "div", 10);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](14, "span", 11);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](15, "+91");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](16, "input", 12);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](17, "p", 13);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](18, "Please enter a valid number ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](19, "span", 14);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](20, " error ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](21, "div", 15);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](22, "button", 16);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](23, "continue ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](24, "span", 17);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](25, " chevron_right ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](26, "div", 15);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](27, "p", 18);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](28, "By Proceeding you agree to the ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](29, "a", 19);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](30, "Terms of use");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](31, " and ");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](32, "a", 19);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](33, "Privacy and policy");

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
          }

          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵproperty"]("id", ctx.modalId);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](8);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵproperty"]("formGroup", ctx.formInstance);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](7);

            _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵproperty"]("formControlName", "UserName");
          }
        },
        directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_3__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NumberValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormControlName],
        styles: [".login-modal[_ngcontent-%COMP%] {\n  background-color: white;\n  width: 33.3%;\n  border-radius: 8px;\n}\n\n.mat-card[_ngcontent-%COMP%] {\n  width: 300px;\n  max-width: 85%;\n  margin: auto;\n}\n\n.heading[_ngcontent-%COMP%] {\n  text-align: center;\n  text-transform: uppercase;\n  font-weight: 200;\n}\n\n.full-width[_ngcontent-%COMP%] {\n  width: 200px;\n}\n\ninput[type=password][_ngcontent-%COMP%] {\n  letter-spacing: 0.25;\n}\n\n.login-title[_ngcontent-%COMP%] {\n  font-size: 12pt;\n  color: black;\n  font-weight: 500;\n  margin-bottom: 0px;\n  text-align: center;\n  font-family: \"Poppins\", sans-serif;\n}\n\n.login-close[_ngcontent-%COMP%] {\n  color: black;\n}\n\n.login-subtitle[_ngcontent-%COMP%] {\n  font-size: 11pt;\n  color: black;\n  margin-top: 0px;\n  margin-bottom: 0px;\n  text-align: center;\n  margin-top: 10px;\n  font-family: \"Poppins\", sans-serif;\n}\n\n.phone-label[_ngcontent-%COMP%] {\n  display: block;\n  margin-bottom: 10px;\n  font-size: 9.2pt;\n  color: black;\n}\n\n.phone-input[_ngcontent-%COMP%] {\n  height: 48px;\n  border: none;\n  color: black !important;\n  font-size: 10pt;\n  border-radius: 8px;\n  background-color: #04040410;\n}\n\n.phone-input[_ngcontent-%COMP%]::-moz-placeholder {\n  font-size: 10pt;\n  color: black;\n}\n\n.phone-input[_ngcontent-%COMP%]::placeholder {\n  font-size: 10pt;\n  color: black;\n}\n\n.phone-submit[_ngcontent-%COMP%] {\n  background-color: #50de89;\n  color: black;\n  height: 48px;\n  font-weight: 500;\n  font-size: 0.8em;\n  text-align: center;\n  border-radius: 6px;\n  text-transform: uppercase;\n}\n\n.phone-input.error-input[_ngcontent-%COMP%] {\n  border-radius: 4px;\n  border-bottom: 1px solid #ff0000 !important;\n}\n\n.phone-code[_ngcontent-%COMP%] {\n  font-size: 10pt;\n  color: black;\n}\n\n.error-text[_ngcontent-%COMP%] {\n  font-size: 9pt;\n  color: #ff0000;\n  margin-top: 10px;\n}\n\n.error-text[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  vertical-align: middle;\n  text-align: right;\n  font-size: 14pt;\n}\n\n.phone-submit[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  vertical-align: middle;\n  font-size: 14pt;\n}\n\n.login-terms[_ngcontent-%COMP%] {\n  font-size: 8pt;\n  color: black;\n  text-align: left;\n  font-weight: 400;\n}\n\n.login-terms[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: #ff5e4d;\n  text-decoration: none !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImxvZ2luLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksdUJBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7QUFDSjs7QUFHQTtFQUNJLFlBQUE7RUFDQSxjQUFBO0VBQ0EsWUFBQTtBQUFKOztBQUdBO0VBQ0ksa0JBQUE7RUFDQSx5QkFBQTtFQUNBLGdCQUFBO0FBQUo7O0FBR0E7RUFDSSxZQUFBO0FBQUo7O0FBR0E7RUFDSSxvQkFBQTtBQUFKOztBQUdBO0VBQ0ksZUFBQTtFQUNBLFlBQUE7RUFDQSxnQkFBQTtFQUNBLGtCQUFBO0VBQ0Esa0JBQUE7RUFDQSxrQ0FBQTtBQUFKOztBQUdBO0VBQ0ksWUFBQTtBQUFKOztBQUdBO0VBQ0ksZUFBQTtFQUNBLFlBQUE7RUFDQSxlQUFBO0VBQ0Esa0JBQUE7RUFDQSxrQkFBQTtFQUNBLGdCQUFBO0VBQ0Esa0NBQUE7QUFBSjs7QUFHQTtFQUNJLGNBQUE7RUFDQSxtQkFBQTtFQUNBLGdCQUFBO0VBQ0EsWUFBQTtBQUFKOztBQUdBO0VBQ0ksWUFBQTtFQUNBLFlBQUE7RUFDQSx1QkFBQTtFQUNBLGVBQUE7RUFDQSxrQkFBQTtFQUNBLDJCQUFBO0FBQUo7O0FBR0E7RUFDSSxlQUFBO0VBQ0EsWUFBQTtBQUFKOztBQUZBO0VBQ0ksZUFBQTtFQUNBLFlBQUE7QUFBSjs7QUFHQTtFQUNJLHlCQUFBO0VBQ0EsWUFBQTtFQUNBLFlBQUE7RUFDQSxnQkFBQTtFQUNBLGdCQUFBO0VBQ0Esa0JBQUE7RUFDQSxrQkFBQTtFQUNBLHlCQUFBO0FBQUo7O0FBR0E7RUFDSSxrQkFBQTtFQUNBLDJDQUFBO0FBQUo7O0FBR0E7RUFDSSxlQUFBO0VBQ0EsWUFBQTtBQUFKOztBQUdBO0VBQ0ksY0FBQTtFQUNBLGNBQUE7RUFDQSxnQkFBQTtBQUFKOztBQUdBO0VBQ0ksc0JBQUE7RUFDQSxpQkFBQTtFQUNBLGVBQUE7QUFBSjs7QUFHQTtFQUNJLHNCQUFBO0VBQ0EsZUFBQTtBQUFKOztBQUdBO0VBQ0ksY0FBQTtFQUNBLFlBQUE7RUFDQSxnQkFBQTtFQUNBLGdCQUFBO0FBQUo7O0FBR0E7RUFDSSxjQUFBO0VBQ0EsZ0NBQUE7QUFBSiIsImZpbGUiOiJsb2dpbi5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5sb2dpbi1tb2RhbCB7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiB3aGl0ZTtcclxuICAgIHdpZHRoOiAzMy4zJTtcclxuICAgIGJvcmRlci1yYWRpdXM6IDhweDtcclxufVxyXG5cclxuXHJcbi5tYXQtY2FyZCB7XHJcbiAgICB3aWR0aDogMzAwcHg7XHJcbiAgICBtYXgtd2lkdGg6IDg1JTtcclxuICAgIG1hcmdpbjogYXV0bztcclxufVxyXG5cclxuLmhlYWRpbmcge1xyXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcclxuICAgIGZvbnQtd2VpZ2h0OiAyMDA7XHJcbn1cclxuXHJcbi5mdWxsLXdpZHRoIHtcclxuICAgIHdpZHRoOiAyMDBweDtcclxufVxyXG5cclxuaW5wdXRbdHlwZT1cInBhc3N3b3JkXCJdIHtcclxuICAgIGxldHRlci1zcGFjaW5nOiAwLjI1O1xyXG59XHJcblxyXG4ubG9naW4tdGl0bGUge1xyXG4gICAgZm9udC1zaXplOiAxMnB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZm9udC13ZWlnaHQ6IDUwMDtcclxuICAgIG1hcmdpbi1ib3R0b206IDBweDtcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgIGZvbnQtZmFtaWx5OiAnUG9wcGlucycsIHNhbnMtc2VyaWY7XHJcbn1cclxuXHJcbi5sb2dpbi1jbG9zZSB7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbn1cclxuXHJcbi5sb2dpbi1zdWJ0aXRsZSB7XHJcbiAgICBmb250LXNpemU6IDExcHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBtYXJnaW4tdG9wOiAwcHg7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAwcHg7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBtYXJnaW4tdG9wOiAxMHB4O1xyXG4gICAgZm9udC1mYW1pbHk6ICdQb3BwaW5zJywgc2Fucy1zZXJpZjtcclxufVxyXG5cclxuLnBob25lLWxhYmVsIHtcclxuICAgIGRpc3BsYXk6IGJsb2NrO1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcclxuICAgIGZvbnQtc2l6ZTogOS4ycHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbn1cclxuXHJcbi5waG9uZS1pbnB1dCB7XHJcbiAgICBoZWlnaHQ6IDQ4cHg7XHJcbiAgICBib3JkZXI6IG5vbmU7XHJcbiAgICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcclxuICAgIGZvbnQtc2l6ZTogMTBwdDtcclxuICAgIGJvcmRlci1yYWRpdXM6IDhweDtcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICMwNDA0MDQxMDtcclxufVxyXG5cclxuLnBob25lLWlucHV0OjpwbGFjZWhvbGRlciB7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbn1cclxuXHJcbi5waG9uZS1zdWJtaXQge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzUwZGU4OTtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIGhlaWdodDogNDhweDtcclxuICAgIGZvbnQtd2VpZ2h0OiA1MDA7XHJcbiAgICBmb250LXNpemU6IDAuOGVtO1xyXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgYm9yZGVyLXJhZGl1czogNnB4O1xyXG4gICAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcclxufVxyXG5cclxuLnBob25lLWlucHV0LmVycm9yLWlucHV0IHtcclxuICAgIGJvcmRlci1yYWRpdXM6IDRweDtcclxuICAgIGJvcmRlci1ib3R0b206IDFweCBzb2xpZCAjZmYwMDAwICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbi5waG9uZS1jb2RlIHtcclxuICAgIGZvbnQtc2l6ZTogMTBwdDtcclxuICAgIGNvbG9yOiBibGFjaztcclxufVxyXG5cclxuLmVycm9yLXRleHQge1xyXG4gICAgZm9udC1zaXplOiA5cHQ7XHJcbiAgICBjb2xvcjogI2ZmMDAwMDtcclxuICAgIG1hcmdpbi10b3A6IDEwcHg7XHJcbn1cclxuXHJcbi5lcnJvci10ZXh0PnNwYW4ge1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIHRleHQtYWxpZ246IHJpZ2h0O1xyXG4gICAgZm9udC1zaXplOiAxNHB0O1xyXG59XHJcblxyXG4ucGhvbmUtc3VibWl0PnNwYW4ge1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIGZvbnQtc2l6ZTogMTRwdDtcclxufVxyXG5cclxuLmxvZ2luLXRlcm1zIHtcclxuICAgIGZvbnQtc2l6ZTogOHB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgdGV4dC1hbGlnbjogbGVmdDtcclxuICAgIGZvbnQtd2VpZ2h0OiA0MDA7XHJcbn1cclxuXHJcbi5sb2dpbi10ZXJtcz5hIHtcclxuICAgIGNvbG9yOiAjZmY1ZTRkO1xyXG4gICAgdGV4dC1kZWNvcmF0aW9uOiBub25lICFpbXBvcnRhbnQ7XHJcbn1cclxuIl19 */"]
      });
      /***/
    },

    /***/
    28564:
    /*!*************************************************!*\
      !*** ./src/app/auth/logout/logout.component.ts ***!
      \*************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "LogoutComponent": function LogoutComponent() {
          return (
            /* binding */
            _LogoutComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/router */
      39895);

      var _LogoutComponent = /*#__PURE__*/function () {
        function _LogoutComponent(router) {
          _classCallCheck(this, _LogoutComponent);

          this.router = router;
        }

        _createClass(_LogoutComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {}
        }]);

        return _LogoutComponent;
      }();

      _LogoutComponent.ɵfac = function LogoutComponent_Factory(t) {
        return new (t || _LogoutComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_1__.Router));
      };

      _LogoutComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({
        type: _LogoutComponent,
        selectors: [["app-logout"]],
        decls: 0,
        vars: 0,
        template: function LogoutComponent_Template(rf, ctx) {},
        styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJsb2dvdXQuY29tcG9uZW50LnNjc3MifQ== */"]
      });
      /***/
    },

    /***/
    51228:
    /*!*********************************************************!*\
      !*** ./src/app/auth/two-factor/two-factor.component.ts ***!
      \*********************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "TwoFactorComponent": function TwoFactorComponent() {
          return (
            /* binding */
            _TwoFactorComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/forms */
      3679);
      /* harmony import */


      var src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/app/shared/base.component */
      87947);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _services_authentication_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ../_services/authentication.service */
      7893);

      var _TwoFactorComponent = /*#__PURE__*/function (_src_app_shared_base_2) {
        _inherits(_TwoFactorComponent, _src_app_shared_base_2);

        var _super3 = _createSuper(_TwoFactorComponent);

        function _TwoFactorComponent(injector, authService) {
          var _this8;

          _classCallCheck(this, _TwoFactorComponent);

          _this8 = _super3.call(this, injector);
          _this8.injector = injector;
          _this8.authService = authService;
          _this8.modalId = 'otp-modal';
          _this8.formInstance = _this8.fb.group({
            OtpCode: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_3__.Validators.required]]
          });
          return _this8;
        }

        _createClass(_TwoFactorComponent, [{
          key: "phoneNumber",
          get: function get() {
            var _a;

            return (_a = this.authService.currentUserValue) === null || _a === void 0 ? void 0 : _a.userName;
          }
        }, {
          key: "isRequiredOTP",
          get: function get() {
            var _a;

            return ((_a = this.authService.currentUserValue) === null || _a === void 0 ? void 0 : _a.requireOTP) === "True";
          }
        }, {
          key: "ngOnInit",
          value: function ngOnInit() {
            var _this9 = this;

            this.loadSpinner = "";
            this.showModal(this.modalId, function () {
              _this9.modalClose();
            });
          }
        }, {
          key: "modalClose",
          value: function modalClose() {
            if (this.router != null) {
              this.router.navigate([{
                outlets: {
                  action: [],
                  primary: []
                }
              }]);
            }
          }
        }, {
          key: "submitOtp",
          value: function submitOtp() {
            var _this10 = this;

            var _a;

            var otp = (_a = this.formInstance.get("OtpCode")) === null || _a === void 0 ? void 0 : _a.value;
            this.showFullSpinner();
            this.apiRequestService.get(src_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.apiUrl + '/auth/verify-otp/' + otp).subscribe(function (res) {
              _this10.formInstance.reset();

              _this10.hideFullSpinner();

              _this10.authService.updateRequireOTP(false);

              _this10.modalClose();
            }, function (error) {
              _this10.modalClose();
            });
          }
        }]);

        return _TwoFactorComponent;
      }(src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_0__.BaseComponent);

      _TwoFactorComponent.ɵfac = function TwoFactorComponent_Factory(t) {
        return new (t || _TwoFactorComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_4__.Injector), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdirectiveInject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_2__.AuthenticationService));
      };

      _TwoFactorComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineComponent"]({
        type: _TwoFactorComponent,
        selectors: [["app-two-factor"]],
        features: [_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵInheritDefinitionFeature"]],
        decls: 29,
        vars: 4,
        consts: [["id", "modal-container"], ["uk-modal", "", "container", "#modal-container", "bg-close", "false", "esc-close", "false", 3, "id"], [1, "uk-modal-dialog", "login-modal"], ["type", "button", "uk-close", "", 1, "uk-modal-close-default"], [1, "uk-modal-body"], ["href", "", 1, "back-link"], [1, "material-icons-outlined"], ["type", "button", "uk-close", "", 1, "uk-modal-close-default", "otp-close"], [1, "otp-title"], [1, "otp-subtitle"], [1, "login-number"], ["uk-grid", "", 1, "uk-grid-small", 3, "formGroup", "ngSubmit"], [1, "uk-width-1-1"], ["type", "number", "placeholder", "Enter OTP", 1, "uk-input", "otp-input", 3, "formControlName"], [1, "resend-text", "not-valid"], ["href", ""], ["type", "submit", 1, "uk-button", "otp-button", "uk-width-1-1"]],
        template: function TwoFactorComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](0, "div", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](1, "div", 1);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](2, "div", 2);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](3, "button", 3);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](4, "div", 4);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementContainerStart"](5);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](6, "a", 5);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](7, "span", 6);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](8, " chevron_left ");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](9, " Back");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](10, "button", 7);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](11, "p", 8);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](12, "Phone number verification");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](13, "p", 9);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](14, "Enter 4 digit code sent to your phone ");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](15, "p", 10);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](16);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](17, "form", 11);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵlistener"]("ngSubmit", function TwoFactorComponent_Template_form_ngSubmit_17_listener() {
              return ctx.submitOtp();
            });

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](18, "div", 12);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelement"](19, "input", 13);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](20, "div", 12);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](21, "p", 14);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](22, "a", 15);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](23, " resend OTP");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](24, "span");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](25, " ( In 60 Secs)");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](26, "div", 12);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementStart"](27, "button", 16);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtext"](28, "Continue");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementContainerEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵelementEnd"]();
          }

          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("id", ctx.modalId);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](15);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵtextInterpolate1"]("+91-", ctx.phoneNumber, "");

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("formGroup", ctx.formInstance);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵadvance"](2);

            _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵproperty"]("formControlName", "OtpCode");
          }
        },
        directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_3__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NumberValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormControlName],
        styles: ["p[_ngcontent-%COMP%], input[_ngcontent-%COMP%] {\n  font-family: \"Poppins\", sans-serif !important;\n}\n\n.otp-grid[_ngcontent-%COMP%] {\n  background-color: white;\n  border-radius: 8px;\n  width: 33.3%;\n}\n\n.otp-modal[_ngcontent-%COMP%] {\n  background-color: white;\n  width: 33.3%;\n  border-radius: 8px;\n}\n\n.otp-title[_ngcontent-%COMP%] {\n  font-size: 14pt;\n  color: black;\n  text-align: center;\n  margin: 0px;\n}\n\n.otp-subtitle[_ngcontent-%COMP%] {\n  font-size: 11pt;\n  color: black;\n  text-align: center;\n  margin-top: 10px;\n  margin: 0px;\n}\n\n.login-number[_ngcontent-%COMP%] {\n  font-size: 14pt !important;\n  color: black;\n  font-weight: 400;\n  text-align: center;\n  font-family: \"Righteous\", sans-serif !important;\n  margin-top: 4px;\n  margin-bottom: 10px;\n}\n\n.otp-close[_ngcontent-%COMP%] {\n  color: black;\n}\n\n.otp-input[_ngcontent-%COMP%] {\n  height: 48px;\n  color: black;\n  background-color: #f1f1f1;\n  margin-top: 20px;\n  border-radius: 8px;\n}\n\n.otp-input[_ngcontent-%COMP%]:focus {\n  border: none;\n}\n\n.otp-button[_ngcontent-%COMP%] {\n  padding: 3px 10px;\n  background-color: #ff5e4d;\n  color: white;\n  border-radius: 8px;\n  text-transform: capitalize;\n}\n\n.resend-text[_ngcontent-%COMP%] {\n  color: #ff5e4d;\n  font-size: 10pt;\n  text-transform: uppercase;\n  text-align: center;\n  text-decoration: none !important;\n}\n\n.resend-text.not-valid[_ngcontent-%COMP%]    > *[_ngcontent-%COMP%] {\n  color: gray !important;\n}\n\n.resend-text.not-valid[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  font-size: 9pt;\n}\n\n.resend-text[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  text-decoration: none;\n  color: #ff5e4d !important;\n}\n\na.back-link[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 9.5pt;\n  text-decoration: none;\n  text-align: left;\n}\n\na.back-link[_ngcontent-%COMP%]:hover {\n  color: #ff5e4d;\n}\n\na.back-link[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  vertical-align: middle;\n  font-size: 10pt;\n}\n\n.otp-close[_ngcontent-%COMP%]    > svg[_ngcontent-%COMP%] {\n  width: 26px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInR3by1mYWN0b3IuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7O0VBRUksNkNBQUE7QUFDSjs7QUFFQTtFQUNJLHVCQUFBO0VBQ0Esa0JBQUE7RUFDQSxZQUFBO0FBQ0o7O0FBRUE7RUFDSSx1QkFBQTtFQUNBLFlBQUE7RUFDQSxrQkFBQTtBQUNKOztBQUVBO0VBQ0ksZUFBQTtFQUNBLFlBQUE7RUFDQSxrQkFBQTtFQUNBLFdBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7RUFDQSxnQkFBQTtFQUNBLFdBQUE7QUFDSjs7QUFFQTtFQUNJLDBCQUFBO0VBQ0EsWUFBQTtFQUNBLGdCQUFBO0VBQ0Esa0JBQUE7RUFDQSwrQ0FBQTtFQUNBLGVBQUE7RUFDQSxtQkFBQTtBQUNKOztBQUVBO0VBQ0ksWUFBQTtBQUNKOztBQUVBO0VBQ0ksWUFBQTtFQUNBLFlBQUE7RUFDQSx5QkFBQTtFQUNBLGdCQUFBO0VBQ0Esa0JBQUE7QUFDSjs7QUFFQTtFQUNJLFlBQUE7QUFDSjs7QUFFQTtFQUNJLGlCQUFBO0VBQ0EseUJBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7RUFDQSwwQkFBQTtBQUNKOztBQUVBO0VBQ0ksY0FBQTtFQUNBLGVBQUE7RUFDQSx5QkFBQTtFQUNBLGtCQUFBO0VBQ0EsZ0NBQUE7QUFDSjs7QUFFQTtFQUNJLHNCQUFBO0FBQ0o7O0FBRUE7RUFDSSxjQUFBO0FBQ0o7O0FBRUE7RUFDSSxxQkFBQTtFQUNBLHlCQUFBO0FBQ0o7O0FBRUE7RUFDSSxZQUFBO0VBQ0EsZ0JBQUE7RUFDQSxxQkFBQTtFQUNBLGdCQUFBO0FBQ0o7O0FBRUE7RUFDSSxjQUFBO0FBQ0o7O0FBRUE7RUFDSSxzQkFBQTtFQUNBLGVBQUE7QUFDSjs7QUFFQTtFQUNJLFdBQUE7QUFDSiIsImZpbGUiOiJ0d28tZmFjdG9yLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsicCxcclxuaW5wdXQge1xyXG4gICAgZm9udC1mYW1pbHk6ICdQb3BwaW5zJywgc2Fucy1zZXJpZiAhaW1wb3J0YW50O1xyXG59XHJcblxyXG4ub3RwLWdyaWQge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7XHJcbiAgICBib3JkZXItcmFkaXVzOiA4cHg7XHJcbiAgICB3aWR0aDogMzMuMyU7XHJcbn1cclxuXHJcbi5vdHAtbW9kYWwge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7XHJcbiAgICB3aWR0aDogMzMuMyU7XHJcbiAgICBib3JkZXItcmFkaXVzOiA4cHg7XHJcbn1cclxuIFxyXG4ub3RwLXRpdGxlIHtcclxuICAgIGZvbnQtc2l6ZTogMTRwdDtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgIG1hcmdpbjogMHB4O1xyXG59XHJcblxyXG4ub3RwLXN1YnRpdGxlIHtcclxuICAgIGZvbnQtc2l6ZTogMTFwdDtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICAgIG1hcmdpbi10b3A6IDEwcHg7XHJcbiAgICBtYXJnaW46IDBweDtcclxufVxyXG5cclxuLmxvZ2luLW51bWJlciB7XHJcbiAgICBmb250LXNpemU6IDE0cHQgIWltcG9ydGFudDtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIGZvbnQtd2VpZ2h0OiA0MDA7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBmb250LWZhbWlseTogJ1JpZ2h0ZW91cycsIHNhbnMtc2VyaWYgIWltcG9ydGFudDtcclxuICAgIG1hcmdpbi10b3A6IDRweDtcclxuICAgIG1hcmdpbi1ib3R0b206IDEwcHg7XHJcbn1cclxuXHJcbi5vdHAtY2xvc2Uge1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG59XHJcblxyXG4ub3RwLWlucHV0IHtcclxuICAgIGhlaWdodDogNDhweDtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICNmMWYxZjE7XHJcbiAgICBtYXJnaW4tdG9wOiAyMHB4O1xyXG4gICAgYm9yZGVyLXJhZGl1czogOHB4O1xyXG59XHJcblxyXG4ub3RwLWlucHV0OmZvY3VzIHtcclxuICAgIGJvcmRlcjogbm9uZTtcclxufVxyXG5cclxuLm90cC1idXR0b24ge1xyXG4gICAgcGFkZGluZzogM3B4IDEwcHg7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZmY1ZTRkO1xyXG4gICAgY29sb3I6IHdoaXRlO1xyXG4gICAgYm9yZGVyLXJhZGl1czogOHB4O1xyXG4gICAgdGV4dC10cmFuc2Zvcm06IGNhcGl0YWxpemU7XHJcbn1cclxuXHJcbi5yZXNlbmQtdGV4dCB7XHJcbiAgICBjb2xvcjogI2ZmNWU0ZDtcclxuICAgIGZvbnQtc2l6ZTogMTBwdDtcclxuICAgIHRleHQtdHJhbnNmb3JtOiB1cHBlcmNhc2U7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICB0ZXh0LWRlY29yYXRpb246IG5vbmUgIWltcG9ydGFudDtcclxufVxyXG5cclxuLnJlc2VuZC10ZXh0Lm5vdC12YWxpZD4qIHtcclxuICAgIGNvbG9yOiBncmF5ICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbi5yZXNlbmQtdGV4dC5ub3QtdmFsaWQ+c3BhbiB7XHJcbiAgICBmb250LXNpemU6IDlwdDtcclxufVxyXG5cclxuLnJlc2VuZC10ZXh0PmEge1xyXG4gICAgdGV4dC1kZWNvcmF0aW9uOiBub25lO1xyXG4gICAgY29sb3I6ICNmZjVlNGQgIWltcG9ydGFudDtcclxufVxyXG5cclxuYS5iYWNrLWxpbmsge1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZm9udC1zaXplOiA5LjVwdDtcclxuICAgIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcclxuICAgIHRleHQtYWxpZ246IGxlZnQ7XHJcbn1cclxuXHJcbmEuYmFjay1saW5rOmhvdmVyIHtcclxuICAgIGNvbG9yOiAjZmY1ZTRkO1xyXG59XHJcblxyXG5hLmJhY2stbGluaz5zcGFuIHtcclxuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbn1cclxuXHJcbi5vdHAtY2xvc2U+c3ZnIHtcclxuICAgIHdpZHRoOiAyNnB4O1xyXG59XHJcbiJdfQ== */"]
      });
      /***/
    },

    /***/
    71987:
    /*!**********************************!*\
      !*** ./src/app/models/common.ts ***!
      \**********************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "BaseFiler": function BaseFiler() {
          return (
            /* binding */
            _BaseFiler
          );
        },

        /* harmony export */
        "MenuItems": function MenuItems() {
          return (
            /* binding */
            _MenuItems
          );
        },

        /* harmony export */
        "SideNavigation": function SideNavigation() {
          return (
            /* binding */
            _SideNavigation
          );
        },

        /* harmony export */
        "ResponseObject": function ResponseObject() {
          return (
            /* binding */
            _ResponseObject
          );
        },

        /* harmony export */
        "ModalRequest": function ModalRequest() {
          return (
            /* binding */
            _ModalRequest
          );
        },

        /* harmony export */
        "ModalType": function ModalType() {
          return (
            /* binding */
            _ModalType
          );
        },

        /* harmony export */
        "Result": function Result() {
          return (
            /* binding */
            _Result
          );
        },

        /* harmony export */
        "ProductDivision": function ProductDivision() {
          return (
            /* binding */
            _ProductDivision
          );
        },

        /* harmony export */
        "OrderStatus": function OrderStatus() {
          return (
            /* binding */
            _OrderStatus
          );
        },

        /* harmony export */
        "PaymentType": function PaymentType() {
          return (
            /* binding */
            _PaymentType
          );
        },

        /* harmony export */
        "ProductQueryType": function ProductQueryType() {
          return (
            /* binding */
            _ProductQueryType
          );
        },

        /* harmony export */
        "enumToKeyValueArray": function enumToKeyValueArray() {
          return (
            /* binding */
            _enumToKeyValueArray
          );
        },

        /* harmony export */
        "transformCamelToSpaces": function transformCamelToSpaces() {
          return (
            /* binding */
            _transformCamelToSpaces
          );
        },

        /* harmony export */
        "StringIsNotNumber": function StringIsNotNumber() {
          return (
            /* binding */
            _StringIsNotNumber
          );
        }
        /* harmony export */

      });

      var _BaseFiler = /*#__PURE__*/_createClass(function _BaseFiler() {
        _classCallCheck(this, _BaseFiler);
      });

      var _MenuItems = /*#__PURE__*/_createClass(function _MenuItems() {
        _classCallCheck(this, _MenuItems);

        this.iconPosition = "left";
        this.visible = true;
        this.isDefault = false;
      });

      var _SideNavigation = /*#__PURE__*/_createClass(function _SideNavigation() {
        _classCallCheck(this, _SideNavigation);

        this.visible = false;
      });

      var _ResponseObject = /*#__PURE__*/_createClass(function _ResponseObject() {
        _classCallCheck(this, _ResponseObject);

        this.IsSuccess = false;
      });

      var _ModalRequest = /*#__PURE__*/_createClass(function _ModalRequest() {
        _classCallCheck(this, _ModalRequest);
      });

      var _ModalType;

      (function (ModalType) {
        ModalType[ModalType["ProductOverview"] = 0] = "ProductOverview";
        ModalType[ModalType["ProductVariant"] = 1] = "ProductVariant";
        ModalType[ModalType["TimingSelection"] = 2] = "TimingSelection";
      })(_ModalType || (_ModalType = {}));

      var _Result;

      (function (Result) {
        Result[Result["ValidationError"] = 0] = "ValidationError";
        Result[Result["Success"] = 1] = "Success";
        Result[Result["Failure"] = 2] = "Failure";
        Result[Result["Error"] = 3] = "Error";
        Result[Result["NotFound"] = 4] = "NotFound";
        Result[Result["Unauthorized"] = 5] = "Unauthorized";
      })(_Result || (_Result = {}));

      var _ProductDivision;

      (function (ProductDivision) {
        ProductDivision[ProductDivision["None"] = -1] = "None";
        ProductDivision[ProductDivision["Grocery"] = 0] = "Grocery";
        ProductDivision[ProductDivision["HygineAndCleaning"] = 1] = "HygineAndCleaning";
        ProductDivision[ProductDivision["PersonalCare"] = 2] = "PersonalCare";
        ProductDivision[ProductDivision["BabiesAndKids"] = 3] = "BabiesAndKids";
        ProductDivision[ProductDivision["Stationeries"] = 4] = "Stationeries";
        ProductDivision[ProductDivision["SportsAndFitnes"] = 5] = "SportsAndFitnes";
        ProductDivision[ProductDivision["HouseHoldItems"] = 6] = "HouseHoldItems";
      })(_ProductDivision || (_ProductDivision = {}));

      var _OrderStatus;

      (function (OrderStatus) {
        OrderStatus[OrderStatus["All"] = 0] = "All";
        OrderStatus[OrderStatus["Placed"] = 1] = "Placed";
        OrderStatus[OrderStatus["Confirmed"] = 2] = "Confirmed";
        OrderStatus[OrderStatus["Packed"] = 3] = "Packed";
        OrderStatus[OrderStatus["Dispatched"] = 4] = "Dispatched";
        OrderStatus[OrderStatus["Delivered"] = 5] = "Delivered";
        OrderStatus[OrderStatus["Cancelled"] = 6] = "Cancelled";
        OrderStatus[OrderStatus["Rejected"] = 7] = "Rejected";
        OrderStatus[OrderStatus["Pending"] = 8] = "Pending";
      })(_OrderStatus || (_OrderStatus = {}));

      var _PaymentType;

      (function (PaymentType) {
        PaymentType[PaymentType["CashOnDelivery"] = 1] = "CashOnDelivery";
        PaymentType[PaymentType["OnlinePayment"] = 2] = "OnlinePayment";
      })(_PaymentType || (_PaymentType = {})); // export enum MeasureType {
      //     Unit,
      //     Gram,
      //     Kg,
      //     Liter,
      //     Ml,
      //     Dozen,
      //     Tray,
      //     Large,
      //     Small,
      //     Medium,
      //     LargePack,
      //     SmallPack,
      //     MediumPack,
      //     Bundle
      // }


      var _ProductQueryType;

      (function (ProductQueryType) {
        ProductQueryType[ProductQueryType["FilterOrNone"] = 0] = "FilterOrNone";
        ProductQueryType[ProductQueryType["Variants"] = 1] = "Variants";
        ProductQueryType[ProductQueryType["Suggestions"] = 2] = "Suggestions";
        ProductQueryType[ProductQueryType["Featured"] = 3] = "Featured";
        ProductQueryType[ProductQueryType["Trending"] = 4] = "Trending";
        ProductQueryType[ProductQueryType["QuickSlides"] = 5] = "QuickSlides";
        ProductQueryType[ProductQueryType["Offers"] = 6] = "Offers";
        ProductQueryType[ProductQueryType["Similars"] = 7] = "Similars";
      })(_ProductQueryType || (_ProductQueryType = {}));

      function _enumToKeyValueArray(enumme) {
        return Object.keys(enumme).filter(_StringIsNotNumber).map(function (k) {
          return {
            name: k,
            id: enumme[k]
          };
        });
      }

      function _transformCamelToSpaces(text) {
        var result = text.replace(/([A-Z])/g, " $1");
        var finalResult = result.charAt(0).toUpperCase() + result.slice(1);
        return finalResult;
      }

      var _StringIsNotNumber = function _StringIsNotNumber(value) {
        return isNaN(Number(value)) === true;
      };
      /***/

    },

    /***/
    98424:
    /*!**************************************************************!*\
      !*** ./src/app/services/api-services/api-request.service.ts ***!
      \**************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "ApiRequestService": function ApiRequestService() {
          return (
            /* binding */
            _ApiRequestService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! rxjs */
      79765);
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! rxjs */
      40205);
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(
      /*! rxjs */
      25917);
      /* harmony import */


      var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/common/http */
      91841);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! rxjs/operators */
      88002);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! rxjs/operators */
      5304);
      /* harmony import */


      var _shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../../shared/services/error-interceptor.service */
      95731);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _ApiRequestService = /*#__PURE__*/function () {
        function _ApiRequestService(injector) {
          var _this11 = this;

          _classCallCheck(this, _ApiRequestService);

          this.injector = injector;
          this.asyncStatus = new rxjs__WEBPACK_IMPORTED_MODULE_1__.Subject();
          this.onAsyncStatus$ = this.asyncStatus.asObservable();
          this.onMessaged = new rxjs__WEBPACK_IMPORTED_MODULE_1__.Subject();
          this.onMessage$ = this.onMessaged.asObservable();
          this.http = injector.get(_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient);
          this.errorIntrcptr = injector.get(_shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_0__.ErrorInterceptorService);
          this.errorIntrcptr.httpError$.subscribe(function (res) {
            _this11.asyncStatus.next(false);

            _this11.onMessaged.next(res);

            return (0, rxjs__WEBPACK_IMPORTED_MODULE_3__.throwError)(res);
          });
        }

        _createClass(_ApiRequestService, [{
          key: "post",
          value: function post(url, data) {
            var _this12 = this;

            this.asyncStatus.next(true);
            return this.http.post(url, data).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.map)(function (res) {
              _this12.asyncStatus.next(false);

              _this12.onMessaged.next(res);

              return res;
            }));
          }
        }, {
          key: "put",
          value: function put(url, data) {
            var _this13 = this;

            this.asyncStatus.next(true);
            return this.http.put(url, data).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.map)(function (res) {
              _this13.asyncStatus.next(false);

              _this13.onMessaged.next(res);

              return res;
            }), (0, rxjs_operators__WEBPACK_IMPORTED_MODULE_5__.catchError)(function (err) {
              return (0, rxjs__WEBPACK_IMPORTED_MODULE_6__.of)(err);
            }));
          }
        }, {
          key: "mapUrlWithQueryString",
          value: function mapUrlWithQueryString(url, data) {
            if (data) {
              var params = new URLSearchParams();

              for (var key in data) {
                params.set(key, data[key]);
              }

              url = url + (url.indexOf("?") < 0 || url.indexOf("?") == url.length - 1 ? "?" : "&") + params.toString();
            }

            return url;
          }
        }, {
          key: "delete",
          value: function _delete(url, data) {
            var _this14 = this;

            this.asyncStatus.next(true);
            url = this.mapUrlWithQueryString(url, data);
            this.asyncStatus.next(true);
            return this.http["delete"](url).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.map)(function (res) {
              _this14.asyncStatus.next(false);

              _this14.onMessaged.next(res);

              return res;
            }));
          }
        }, {
          key: "get",
          value: function get(url, data) {
            var _this15 = this;

            this.asyncStatus.next(true);
            url = this.mapUrlWithQueryString(url, data);
            this.asyncStatus.next(true);
            return this.http.get(url).pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.map)(function (res) {
              _this15.asyncStatus.next(false);

              _this15.onMessaged.next(res);

              return res;
            }));
          }
        }, {
          key: "showMessage",
          value: function showMessage(res) {
            this.onMessaged.next(res);
          }
        }]);

        return _ApiRequestService;
      }();

      _ApiRequestService.ɵfac = function ApiRequestService_Factory(t) {
        return new (t || _ApiRequestService)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵinject"](_angular_core__WEBPACK_IMPORTED_MODULE_7__.Injector));
      };

      _ApiRequestService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineInjectable"]({
        token: _ApiRequestService,
        factory: _ApiRequestService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    91294:
    /*!***************************************************************!*\
      !*** ./src/app/services/api-services/notification.service.ts ***!
      \***************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "NotificationMessageService": function NotificationMessageService() {
          return (
            /* binding */
            _NotificationMessageService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! rxjs */
      79765);
      /* harmony import */


      var _environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../../../environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _api_request_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./api-request.service */
      98424);
      /* harmony import */


      var src_app_auth_services_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! src/app/auth/_services/user.service */
      4903);

      var _NotificationMessageService = /*#__PURE__*/function () {
        function _NotificationMessageService(apiService, userService) {
          _classCallCheck(this, _NotificationMessageService);

          this.apiService = apiService;
          this.userService = userService;
          this.notificationFetch = new rxjs__WEBPACK_IMPORTED_MODULE_3__.Subject();
          this.onNotificationFetched$ = this.notificationFetch.asObservable();
          this.save_notification_token_url = _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl + "app-notification/save-system-key";
          this.save_pushed_notification_url = _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl + "app-notification/save-pushed-notification";
          this.fetch_notification = _environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl + "app-notification/fetch-notification";
        }

        _createClass(_NotificationMessageService, [{
          key: "saveNotificationToken",
          value: function saveNotificationToken(notificaitonTokenObj) {
            console.log('saving token');
            return this.apiService.post(this.save_notification_token_url, notificaitonTokenObj);
          }
        }, {
          key: "savePushedNotificationUrl",
          value: function savePushedNotificationUrl(pushedNtificationObj) {
            return this.apiService.post(this.save_pushed_notification_url, pushedNtificationObj);
          }
        }, {
          key: "startFetchningNotifications",
          value: function startFetchningNotifications() {
            var _this16 = this;

            this.interval = setInterval(function () {
              _this16.apiService.get(_this16.fetch_notification).subscribe(function (res) {
                if (res != null && res.Data != null && res.Data.length > 0) {
                  _this16.notificationFetch.next(res.Data);
                }
              });
            }, 10000);
          }
        }]);

        return _NotificationMessageService;
      }();

      _NotificationMessageService.ɵfac = function NotificationMessageService_Factory(t) {
        return new (t || _NotificationMessageService)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](_api_request_service__WEBPACK_IMPORTED_MODULE_1__.ApiRequestService), _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](src_app_auth_services_user_service__WEBPACK_IMPORTED_MODULE_2__.UserService));
      };

      _NotificationMessageService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjectable"]({
        token: _NotificationMessageService,
        factory: _NotificationMessageService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    39672:
    /*!***********************************************************!*\
      !*** ./src/app/services/fiire-cloud-messaging-service.ts ***!
      \***********************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "FireCloudMessagingService": function FireCloudMessagingService() {
          return (
            /* binding */
            _FireCloudMessagingService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! rxjs */
      26215);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _angular_fire_compat_messaging__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/fire/compat/messaging */
      52577);
      /* harmony import */


      var _api_services_notification_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ./api-services/notification.service */
      91294);

      var _FireCloudMessagingService = /*#__PURE__*/function () {
        function _FireCloudMessagingService(angularFireMessaging, notificationMessageService) {
          _classCallCheck(this, _FireCloudMessagingService);

          this.angularFireMessaging = angularFireMessaging;
          this.notificationMessageService = notificationMessageService;
          this.currentMessage = new rxjs__WEBPACK_IMPORTED_MODULE_1__.BehaviorSubject(null);
        }

        _createClass(_FireCloudMessagingService, [{
          key: "requestPermission",
          value: function requestPermission() {
            var _this17 = this;

            this.angularFireMessaging.requestPermission.subscribe(function (result) {
              console.log('requestPermission --- ', result);
              console.log("\n");

              if (result == 'granted') {
                localStorage.setItem("NotificationPermission", "true");
                localStorage.setItem("NotificationIdGenerated", "false");
              }
            }, function (err) {
              console.error('Unable to get permission to notify.', err);
            });
            this.angularFireMessaging.requestToken.subscribe(function (token) {
              console.log("Token: \n" + token);
              console.log("\n");

              if (localStorage.getItem("NotificationPermission") == "true" && localStorage.getItem("NotificationIdGenerated") == "false") {
                var request = {
                  UserToken: token,
                  UserId: null
                };

                _this17.notificationMessageService.saveNotificationToken(request).subscribe(function (res) {
                  console.log("notification saved");

                  if (res.IsSuccess == true) {
                    localStorage.setItem("NotificationIdGenerated", "true");
                  }
                });
              }
            }, function (err) {
              console.error('Unable to get permission to notify.', err);
            });
          }
        }, {
          key: "receiveMessage",
          value: function receiveMessage() {
            var _this18 = this;

            this.angularFireMessaging.messages.subscribe(function (messaging) {
              console.log(messaging);
              console.log('new message received. ', messaging);

              _this18.notificationMessageService.savePushedNotificationUrl(messaging).subscribe();

              _this18.currentMessage.next(messaging);
            });
          }
        }]);

        return _FireCloudMessagingService;
      }();

      _FireCloudMessagingService.ɵfac = function FireCloudMessagingService_Factory(t) {
        return new (t || _FireCloudMessagingService)(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵinject"](_angular_fire_compat_messaging__WEBPACK_IMPORTED_MODULE_3__.AngularFireMessaging), _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵinject"](_api_services_notification_service__WEBPACK_IMPORTED_MODULE_0__.NotificationMessageService));
      };

      _FireCloudMessagingService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineInjectable"]({
        token: _FireCloudMessagingService,
        factory: _FireCloudMessagingService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    29004:
    /*!***********************************************!*\
      !*** ./src/app/services/utilities.service.ts ***!
      \***********************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "UtilitiesService": function UtilitiesService() {
          return (
            /* binding */
            _UtilitiesService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! rxjs */
      79765);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _UtilitiesService = /*#__PURE__*/function () {
        function _UtilitiesService() {
          _classCallCheck(this, _UtilitiesService);

          this._openCloseModalDialog = new rxjs__WEBPACK_IMPORTED_MODULE_0__.Subject();
          this.dialogRequest = this._openCloseModalDialog.asObservable();
        }

        _createClass(_UtilitiesService, [{
          key: "closeModalDialog",
          value: function closeModalDialog(request) {
            request.open = false;

            this._openCloseModalDialog.next(request);
          }
        }, {
          key: "openModalDialog",
          value: function openModalDialog(request) {
            request.open = true;

            this._openCloseModalDialog.next(request);
          }
        }]);

        return _UtilitiesService;
      }();

      _UtilitiesService.ɵfac = function UtilitiesService_Factory(t) {
        return new (t || _UtilitiesService)();
      };

      _UtilitiesService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({
        token: _UtilitiesService,
        factory: _UtilitiesService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    1592:
    /*!*******************************************************!*\
      !*** ./src/app/shared/activity/activity.component.ts ***!
      \*******************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "ActivityComponent": function ActivityComponent() {
          return (
            /* binding */
            _ActivityComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/common */
      38583);
      /* harmony import */


      var _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../load-spinner/load-spinner.component */
      10575);

      function ActivityComponent_load_spinner_0_Template(rf, ctx) {
        if (rf & 1) {
          _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](0, "load-spinner");
        }
      }

      function ActivityComponent_ng_content_1_Template(rf, ctx) {
        if (rf & 1) {
          _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵprojection"](0, 0, ["*ngIf", "!isLoading"]);
        }
      }

      var _c0 = ["*"];

      var _ActivityComponent = /*#__PURE__*/_createClass(function _ActivityComponent() {
        _classCallCheck(this, _ActivityComponent);

        this.isLoading = false;
      });

      _ActivityComponent.ɵfac = function ActivityComponent_Factory(t) {
        return new (t || _ActivityComponent)();
      };

      _ActivityComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({
        type: _ActivityComponent,
        selectors: [["activity"]],
        inputs: {
          isLoading: "isLoading"
        },
        ngContentSelectors: _c0,
        decls: 2,
        vars: 2,
        consts: [[4, "ngIf"]],
        template: function ActivityComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵprojectionDef"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](0, ActivityComponent_load_spinner_0_Template, 1, 0, "load-spinner", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtemplate"](1, ActivityComponent_ng_content_1_Template, 1, 0, "ng-content", 0);
          }

          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", ctx.isLoading);

            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngIf", !ctx.isLoading);
          }
        },
        directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.NgIf, _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_0__.LoadSpinnerComponent],
        styles: ["[_nghost-%COMP%] {\n  height: 100vh;\n  display: flex;\n  flex-direction: column;\n}\n\nload-spinner[_ngcontent-%COMP%] {\n  margin: auto auto;\n  transform: translateY(-50%);\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImFjdGl2aXR5LmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksYUFBQTtFQUNBLGFBQUE7RUFDQSxzQkFBQTtBQUNKOztBQUVFO0VBQ0UsaUJBQUE7RUFDQSwyQkFBQTtBQUNKIiwiZmlsZSI6ImFjdGl2aXR5LmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiOmhvc3QgeyBcclxuICAgIGhlaWdodDoxMDB2aDtcclxuICAgIGRpc3BsYXk6IGZsZXg7XHJcbiAgICBmbGV4LWRpcmVjdGlvbjogY29sdW1uO1xyXG4gIH0gXHJcbiAgXHJcbiAgbG9hZC1zcGlubmVye1xyXG4gICAgbWFyZ2luOmF1dG8gYXV0bztcclxuICAgIHRyYW5zZm9ybTogdHJhbnNsYXRlWSgtNTAlKTsgXHJcbiAgfSJdfQ== */"]
      });
      /***/
    },

    /***/
    96196:
    /*!*********************************************************************************!*\
      !*** ./src/app/shared/banner-image-carousel/banner-image-carousel.component.ts ***!
      \*********************************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "BannerImageCarouselComponent": function BannerImageCarouselComponent() {
          return (
            /* binding */
            _BannerImageCarouselComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _BannerImageCarouselComponent = /*#__PURE__*/function () {
        function _BannerImageCarouselComponent() {
          _classCallCheck(this, _BannerImageCarouselComponent);

          this.baseUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.uploadsUrl;
          this.isHandset$ = !src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.isDesktop;
          this.containMode = false;
          this.isAutoSlide = true; // next() {
          //   this.usefulSwiper.swiper.slideNext();
          // }
          // previous() {
          //   this.usefulSwiper.swiper.slidePrev();
          // }

          this.title = 'NG7Swiper';
        } // menu: string[] = ["", "", ""];
        // pagination: any = {
        //   el: ".swiper-pagination",
        //   clicable: true
        // };
        // config: SwiperOptions = {
        //   navigation: {
        //     nextEl: '.swiper-button-next1',
        //     prevEl: '.swiper-button-prev1'
        //   },
        //   speed: 1500,
        //   initialSlide: 1,
        //   slidesPerView: 1,
        //   spaceBetween: 0, // Space between each Item,
        //   loop: true,
        //   pagination: this.pagination,
        //   grabCursor: true,
        //   //paginationClickable: true,  
        // };


        _createClass(_BannerImageCarouselComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {
            if (this.isAutoSlide) {// this.intervalEvent = setInterval(() => {
              //   this.usefulSwiper.swiper.slideNext();
              // }, 4000);
            }
          }
        }, {
          key: "ngOnDestroy",
          value: function ngOnDestroy() {
            if (this.isAutoSlide) {//clearInterval(this.intervalEvent);
            }
          }
        }]);

        return _BannerImageCarouselComponent;
      }();

      _BannerImageCarouselComponent.ɵfac = function BannerImageCarouselComponent_Factory(t) {
        return new (t || _BannerImageCarouselComponent)();
      };

      _BannerImageCarouselComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({
        type: _BannerImageCarouselComponent,
        selectors: [["banner-carousel"]],
        inputs: {
          imageDataList: "imageDataList",
          height: "height",
          width: "width",
          containMode: "containMode",
          isAutoSlide: "isAutoSlide"
        },
        decls: 0,
        vars: 0,
        template: function BannerImageCarouselComponent_Template(rf, ctx) {},
        styles: [".swiper-slide[_ngcontent-%COMP%] {\n  text-align: center;\n  background-size: 100% auto;\n  background-repeat: no-repeat;\n  background-position: center;\n  background-size: cover;\n}\n\n.small_carousel[_ngcontent-%COMP%]   .swiper-slide[_ngcontent-%COMP%] {\n  background-size: contain !important;\n  min-height: 200px;\n  padding: 10px;\n}\n\ndiv#pagination.swiper-pagination[_ngcontent-%COMP%] {\n  position: absolute;\n  bottom: 0px;\n  width: 100%;\n  height: auto;\n  left: auto;\n  margin: 0;\n}\n\n.swiper-button-prev[_ngcontent-%COMP%]:after, .swiper-container-rtl[_ngcontent-%COMP%]   .swiper-button-next[_ngcontent-%COMP%]:after {\n  content: \"\" !important;\n}\n\n.swiper-button-next[_ngcontent-%COMP%]:after, .swiper-container-rtl[_ngcontent-%COMP%]   .swiper-button-prev[_ngcontent-%COMP%]:after {\n  content: \"\" !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImJhbm5lci1pbWFnZS1jYXJvdXNlbC5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGtCQUFBO0VBQ0EsMEJBQUE7RUFDQSw0QkFBQTtFQUNBLDJCQUFBO0VBQ0Esc0JBQUE7QUFDRjs7QUFHQTtFQUNFLG1DQUFBO0VBQ0EsaUJBQUE7RUFDQSxhQUFBO0FBQUY7O0FBSUE7RUFDRSxrQkFBQTtFQUNBLFdBQUE7RUFDQSxXQUFBO0VBQ0EsWUFBQTtFQUNBLFVBQUE7RUFDQSxTQUFBO0FBREY7O0FBS0E7O0VBRUUsc0JBQUE7QUFGRjs7QUFLQTs7RUFFRSxzQkFBQTtBQUZGIiwiZmlsZSI6ImJhbm5lci1pbWFnZS1jYXJvdXNlbC5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5zd2lwZXItc2xpZGUge1xyXG4gIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICBiYWNrZ3JvdW5kLXNpemU6IDEwMCUgYXV0bztcclxuICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xyXG4gIGJhY2tncm91bmQtcG9zaXRpb246IGNlbnRlcjtcclxuICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xyXG5cclxufVxyXG5cclxuLnNtYWxsX2Nhcm91c2VsIC5zd2lwZXItc2xpZGUge1xyXG4gIGJhY2tncm91bmQtc2l6ZTogY29udGFpbiAhaW1wb3J0YW50O1xyXG4gIG1pbi1oZWlnaHQ6IDIwMHB4O1xyXG4gIHBhZGRpbmc6IDEwcHg7XHJcbn1cclxuXHJcblxyXG5kaXYjcGFnaW5hdGlvbi5zd2lwZXItcGFnaW5hdGlvbiB7XHJcbiAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gIGJvdHRvbTogMHB4O1xyXG4gIHdpZHRoOiAxMDAlO1xyXG4gIGhlaWdodDogYXV0bztcclxuICBsZWZ0OiBhdXRvO1xyXG4gIG1hcmdpbjogMDtcclxuXHJcbn1cclxuXHJcbi5zd2lwZXItYnV0dG9uLXByZXY6YWZ0ZXIsXHJcbi5zd2lwZXItY29udGFpbmVyLXJ0bCAuc3dpcGVyLWJ1dHRvbi1uZXh0OmFmdGVyIHtcclxuICBjb250ZW50OiAnJyAhaW1wb3J0YW50O1xyXG59XHJcblxyXG4uc3dpcGVyLWJ1dHRvbi1uZXh0OmFmdGVyLFxyXG4uc3dpcGVyLWNvbnRhaW5lci1ydGwgLnN3aXBlci1idXR0b24tcHJldjphZnRlciB7XHJcbiAgY29udGVudDogJycgIWltcG9ydGFudDtcclxufVxyXG4iXX0= */"]
      });
      /***/
    },

    /***/
    87947:
    /*!******************************************!*\
      !*** ./src/app/shared/base.component.ts ***!
      \******************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "BaseComponent": function BaseComponent() {
          return (
            /* binding */
            _BaseComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_forms__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! @angular/forms */
      3679);
      /* harmony import */


      var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! src/environments/environment */
      92340);
      /* harmony import */


      var _services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./services/error-interceptor.service */
      95731);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var ngx_spinner__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(
      /*! ngx-spinner */
      79866);
      /* harmony import */


      var _services_api_services_api_request_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ../services/api-services/api-request.service */
      98424);
      /* harmony import */


      var _services_utilities_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! ../services/utilities.service */
      29004);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _BaseComponent = /*#__PURE__*/function () {
        function _BaseComponent(injector) {
          var _this19 = this;

          _classCallCheck(this, _BaseComponent);

          this.injector = injector;
          this.messageShown = false;
          this.hasBottomNavigation = true;
          this.baseUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl;
          this.loading = false;
          this.loadSpinner = "loadSpinner";
          this.spinnerOptions = {
            type: "ball-spin-clockwise",
            size: "small",
            bdColor: "rgba(0,0,0,0)",
            color: "#329225",
            fullScreen: false
          };
          this.fb = injector.get(_angular_forms__WEBPACK_IMPORTED_MODULE_4__.FormBuilder);
          this.router = injector.get(_angular_router__WEBPACK_IMPORTED_MODULE_5__.Router);
          this.errorIntrcptr = injector.get(_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_1__.ErrorInterceptorService);
          this.spinner = injector.get(ngx_spinner__WEBPACK_IMPORTED_MODULE_6__.NgxSpinnerService);
          this.route = injector.get(_angular_router__WEBPACK_IMPORTED_MODULE_5__.ActivatedRoute);
          this.apiRequestService = injector.get(_services_api_services_api_request_service__WEBPACK_IMPORTED_MODULE_2__.ApiRequestService);
          this.utilities = injector.get(_services_utilities_service__WEBPACK_IMPORTED_MODULE_3__.UtilitiesService);
          this.subscription = this.apiRequestService.onAsyncStatus$.subscribe(function (res) {
            if (res) {
              _this19.showSpinner();
            } else {
              _this19.hideSpinner();
            }
          });
        }

        _createClass(_BaseComponent, [{
          key: "returnUrl",
          get: function get() {
            var routes = this.router.url.split("return");

            if (routes.length > 1) {
              return {
                "return": routes[1].replace('/', '')
              };
            } else {
              return {};
            }
          }
        }, {
          key: "resetForm",
          value: function resetForm(form) {
            form.reset();
            form.markAsPristine();
            form.markAsUntouched();
          }
        }, {
          key: "ngOnInit",
          value: function ngOnInit() {}
        }, {
          key: "showModal",
          value: function showModal(name, callBack) {
            if (name.charAt(0) != "#") {
              name = "#" + name;
            }

            setTimeout(function () {
              var modal = UIkit.modal(name);

              if (modal) {
                UIkit.modal(name).show();
                UIkit.util.on(name, 'hidden', function () {
                  if (callBack) callBack();
                });
              }
            }, 0);
          }
        }, {
          key: "hideModal",
          value: function hideModal(name) {
            var domReUse = arguments.length > 1 && arguments[1] !== undefined ? arguments[1] : false;

            if (name.charAt(0) != "#") {
              name = "#" + name;
            }

            var _name = name.split("#")[1];
            setTimeout(function () {
              var modal = UIkit.modal(name);
              if (modal) modal.hide();

              if (!domReUse) {
                setTimeout(function () {
                  var ele = document.getElementById(_name);
                  ele === null || ele === void 0 ? void 0 : ele.remove();
                }, 100);
              }
            }, 0);
          }
        }, {
          key: "ngOnDestroy",
          value: function ngOnDestroy() {
            if (this.subscription) {
              console.log("UnSubscribing the Interceptor");
              this.subscription.unsubscribe();
            }

            this.router = null;
            this.errorIntrcptr = null;
          }
        }, {
          key: "showSpinner",
          value: function showSpinner() {
            if (this.loadSpinner != "") {
              this.spinner.show(this.loadSpinner, this.spinnerOptions);
            } else {
              this.showFullSpinner();
            }
          }
        }, {
          key: "hideSpinner",
          value: function hideSpinner() {
            if (this.loadSpinner != "") {
              this.spinner.hide(this.loadSpinner);
            } else {
              this.hideFullSpinner();
            }
          }
        }, {
          key: "showFullSpinner",
          value: function showFullSpinner() {
            this.spinner.show();
          }
        }, {
          key: "hideFullSpinner",
          value: function hideFullSpinner() {
            this.spinner.hide();
          }
        }, {
          key: "getDay",
          value: function getDay(dayId) {
            var date = new Date();
            var ind = date.getDay() < 6 ? date.getDay() + 1 : 0;

            while (ind != dayId) {
              date = this.addDays(date, 1);
              ind = date.getDay() < 6 ? date.getDay() + 1 : 0;
            }

            return date;
          }
        }, {
          key: "tConvert",
          value: function tConvert(_hours, _minutes) {
            if (_hours == null || _minutes == null) {
              return "";
            } // Check correct time format and split into components


            _hours = parseInt(_hours) < 10 ? "0" + _hours : _hours;
            _minutes = parseInt(_minutes) < 10 ? "0" + _minutes : _minutes;

            var time = (_hours + ":" + _minutes).toString().match(/^([01]\d|2[0-3])(:)([0-5]\d)(:[0-5]\d)?$/) || _hours + ":" + _minutes;

            if (time.length > 1) {
              // If time format correct
              time = time.slice(1); // Remove full string match value

              time[5] = +time[0] < 12 ? 'AM' : 'PM'; // Set AM/PM

              time[0] = +time[0] % 12 || 12; // Adjust hours
            }

            return time.join(':').replace(":::", ":").replace(":::", " "); // return adjusted time or original string
          }
        }, {
          key: "addDays",
          value: function addDays(theDate, days) {
            return new Date(theDate.getTime() + days * 24 * 60 * 60 * 1000);
          }
        }]);

        return _BaseComponent;
      }();

      _BaseComponent.ɵfac = function BaseComponent_Factory(t) {
        return new (t || _BaseComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_7__.Injector));
      };

      _BaseComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_7__["ɵɵdefineComponent"]({
        type: _BaseComponent,
        selectors: [["ng-component"]],
        decls: 0,
        vars: 0,
        template: function BaseComponent_Template(rf, ctx) {},
        encapsulation: 2
      });
      /***/
    },

    /***/
    80552:
    /*!*************************************************!*\
      !*** ./src/app/shared/directives/scroll-end.ts ***!
      \*************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "ScrollEndDirective": function ScrollEndDirective() {
          return (
            /* binding */
            _ScrollEndDirective
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! rxjs */
      22759);
      /* harmony import */


      var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! rxjs/operators */
      88002);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/router */
      39895);

      var _ScrollEndDirective = /*#__PURE__*/function () {
        function _ScrollEndDirective(el, render, router) {
          _classCallCheck(this, _ScrollEndDirective);

          this.el = el;
          this.render = render;
          this.router = router;
          this.scrollerEnabled = true;
          this.triggered = false;
          this.scrollEndReached = new _angular_core__WEBPACK_IMPORTED_MODULE_0__.EventEmitter();
        }

        _createClass(_ScrollEndDirective, [{
          key: "ngAfterViewInit",
          value: function ngAfterViewInit() {
            var _this20 = this;

            if (!this.scrollerEnabled) return;

            if (this.scrollingParent == "") {
              var _window = this.container = window;

              var scroll$ = (0, rxjs__WEBPACK_IMPORTED_MODULE_1__.fromEvent)(_window.document, 'scroll').pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_2__.map)(function () {
                return _window;
              }));
              scroll$.subscribe(function (element) {
                _this20.onWindowScroll(element);
              });
            } else {
              this.container = document.querySelector(this.scrollingParent);

              var _scroll$ = (0, rxjs__WEBPACK_IMPORTED_MODULE_1__.fromEvent)(this.container, 'scroll').pipe((0, rxjs_operators__WEBPACK_IMPORTED_MODULE_2__.map)(function () {
                return _this20.container;
              }));

              _scroll$.subscribe(function (element) {
                _this20.onWindowScroll(element);
              });
            }

            this.router.events.subscribe(function (url) {
              var sideBar = _this20.el.nativeElement;

              if (_this20.container instanceof Window) {
                _this20.container.document.body.scrollTop = 0;
              } else if (_this20.container instanceof Element) {
                _this20.container.scrollTop = 0;
              }

              setTimeout(function () {
                _this20.onWindowScroll(_this20.container);
              }, 0);
            });
          }
        }, {
          key: "ngOnInit",
          value: function ngOnInit() {}
        }, {
          key: "getOffset",
          value: function getOffset(el) {
            var rect = el.getBoundingClientRect();
            return {
              left: rect.left + window.scrollX,
              top: rect.top + window.scrollY
            };
          }
        }, {
          key: "onWindowScroll",
          value: function onWindowScroll(element) {
            var _this21 = this;

            var content = this.el.nativeElement;
            var totalHeight = content.clientHeight;
            var scrolledHeight = 0;

            if (this.container instanceof Window) {
              scrolledHeight = this.container.document.body.scrollTop + this.container.document.body.clientHeight;
            } else {
              scrolledHeight = this.container.scrollTop + this.container.clientHeight;
            }

            if (scrolledHeight >= totalHeight) {
              if (!this.triggered) {
                this.triggered = true;
                setTimeout(function () {
                  _this21.triggered = false;
                }, 1000);
                this.scrollEndReached.emit();
              }
            }
          }
        }]);

        return _ScrollEndDirective;
      }();

      _ScrollEndDirective.ɵfac = function ScrollEndDirective_Factory(t) {
        return new (t || _ScrollEndDirective)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_0__.ElementRef), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_0__.Renderer2), _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_3__.Router));
      };

      _ScrollEndDirective.ɵdir = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineDirective"]({
        type: _ScrollEndDirective,
        selectors: [["", "scrollEnd", ""]],
        inputs: {
          scrollerEnabled: "scrollerEnabled",
          scrollingParent: "scrollingParent"
        },
        outputs: {
          scrollEndReached: "scrollEndReached"
        }
      });
      /***/
    },

    /***/
    61184:
    /*!***************************************************!*\
      !*** ./src/app/shared/layout/layout.component.ts ***!
      \***************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "LayoutComponent": function LayoutComponent() {
          return (
            /* binding */
            _LayoutComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _base_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ../base.component */
      87947);
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/common */
      38583);
      /* harmony import */


      var _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ../load-spinner/load-spinner.component */
      10575);

      function LayoutComponent_div_0_Template(rf, ctx) {
        if (rf & 1) {
          _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵelementStart"](0, "div", 2);

          _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵelement"](1, "load-spinner");

          _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵelementEnd"]();
        }
      }

      function LayoutComponent_ng_content_1_Template(rf, ctx) {
        if (rf & 1) {
          _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵprojection"](0, 0, ["*ngIf", "show && !isLoading"]);
        }
      }

      var _c0 = ["*"];

      var _LayoutComponent = /*#__PURE__*/function (_base_component__WEBP) {
        _inherits(_LayoutComponent, _base_component__WEBP);

        var _super4 = _createSuper(_LayoutComponent);

        function _LayoutComponent(injector) {
          var _this22;

          _classCallCheck(this, _LayoutComponent);

          _this22 = _super4.call(this, injector);
          _this22.injector = injector;
          _this22.loadDelay = 0;
          _this22.isLoading = false;
          _this22.onLoadComplete = new _angular_core__WEBPACK_IMPORTED_MODULE_2__.EventEmitter();
          _this22.show = false;
          return _this22;
        }

        _createClass(_LayoutComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {
            var _this23 = this;

            setTimeout(function () {
              _this23.show = true;

              _this23.onLoadComplete.emit();
            }, this.loadDelay);
          }
        }]);

        return _LayoutComponent;
      }(_base_component__WEBPACK_IMPORTED_MODULE_0__.BaseComponent);

      _LayoutComponent.ɵfac = function LayoutComponent_Factory(t) {
        return new (t || _LayoutComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_2__.Injector));
      };

      _LayoutComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineComponent"]({
        type: _LayoutComponent,
        selectors: [["layout"]],
        inputs: {
          loadDelay: "loadDelay",
          isLoading: "isLoading"
        },
        outputs: {
          onLoadComplete: "onLoadComplete"
        },
        features: [_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵInheritDefinitionFeature"]],
        ngContentSelectors: _c0,
        decls: 2,
        vars: 2,
        consts: [["class", "spinner-container", 4, "ngIf"], [4, "ngIf"], [1, "spinner-container"]],
        template: function LayoutComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵprojectionDef"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵtemplate"](0, LayoutComponent_div_0_Template, 2, 0, "div", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵtemplate"](1, LayoutComponent_ng_content_1_Template, 1, 0, "ng-content", 1);
          }

          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵproperty"]("ngIf", ctx.show && ctx.isLoading);

            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵproperty"]("ngIf", ctx.show && !ctx.isLoading);
          }
        },
        directives: [_angular_common__WEBPACK_IMPORTED_MODULE_3__.NgIf, _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_1__.LoadSpinnerComponent],
        styles: ["[_nghost-%COMP%] {\n  flex-grow: 1;\n  overflow: auto;\n  padding-bottom: 55px;\n  background-color: white;\n}\n\n.spinner-container[_ngcontent-%COMP%] {\n  width: 100%;\n  text-align: center;\n  margin-top: 35vh;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImxheW91dC5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLFlBQUE7RUFDQSxjQUFBO0VBQ0Esb0JBQUE7RUFDQSx1QkFBQTtBQUNGOztBQUVBO0VBQ0UsV0FBQTtFQUNBLGtCQUFBO0VBQ0EsZ0JBQUE7QUFDRiIsImZpbGUiOiJsYXlvdXQuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyI6aG9zdCB7XHJcbiAgZmxleC1ncm93OiAxO1xyXG4gIG92ZXJmbG93OiBhdXRvOyAgXHJcbiAgcGFkZGluZy1ib3R0b206IDU1cHg7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjp3aGl0ZTtcclxufVxyXG5cclxuLnNwaW5uZXItY29udGFpbmVyeyBcclxuICB3aWR0aDoxMDAlO1xyXG4gIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICBtYXJnaW4tdG9wOjM1dmg7IFxyXG59XHJcbiAgIl19 */"]
      });
      /***/
    },

    /***/
    10575:
    /*!***************************************************************!*\
      !*** ./src/app/shared/load-spinner/load-spinner.component.ts ***!
      \***************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "LoadSpinnerComponent": function LoadSpinnerComponent() {
          return (
            /* binding */
            _LoadSpinnerComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _LoadSpinnerComponent = /*#__PURE__*/function () {
        function _LoadSpinnerComponent() {
          _classCallCheck(this, _LoadSpinnerComponent);
        }

        _createClass(_LoadSpinnerComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {}
        }]);

        return _LoadSpinnerComponent;
      }();

      _LoadSpinnerComponent.ɵfac = function LoadSpinnerComponent_Factory(t) {
        return new (t || _LoadSpinnerComponent)();
      };

      _LoadSpinnerComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({
        type: _LoadSpinnerComponent,
        selectors: [["load-spinner"]],
        decls: 4,
        vars: 0,
        consts: [[1, "load-spinner"], ["viewBox", "25 25 50 50"], ["cx", "50", "cy", "50", "r", "20"]],
        template: function LoadSpinnerComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnamespaceSVG"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "svg", 1);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](2, "circle", 2);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3, "`");
          }
        },
        styles: [".load-spinner[_ngcontent-%COMP%]   svg[_ngcontent-%COMP%] {\n  width: 3.75em;\n  transform-origin: center;\n  animation: rotate 2s linear infinite;\n}\n\n.load-spinner[_ngcontent-%COMP%]   circle[_ngcontent-%COMP%] {\n  fill: none;\n  stroke: #63b6dc;\n  stroke-width: 3;\n  stroke-dasharray: 1, 200;\n  stroke-dashoffset: 0;\n  stroke-linecap: round;\n  animation: dash 1.5s ease-in-out infinite;\n}\n\n@keyframes rotate {\n  100% {\n    transform: rotate(360deg);\n  }\n}\n\n@keyframes dash {\n  0% {\n    stroke-dasharray: 1, 200;\n    stroke-dashoffset: 0;\n  }\n  50% {\n    stroke-dasharray: 90, 200;\n    stroke-dashoffset: -35px;\n  }\n  100% {\n    stroke-dashoffset: -125px;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImxvYWQtc3Bpbm5lci5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLGFBQUE7RUFDQSx3QkFBQTtFQUNBLG9DQUFBO0FBQ0Y7O0FBRUE7RUFDRSxVQUFBO0VBQ0EsZUFBQTtFQUNBLGVBQUE7RUFDQSx3QkFBQTtFQUNBLG9CQUFBO0VBQ0EscUJBQUE7RUFDQSx5Q0FBQTtBQUNGOztBQUVBO0VBQ0U7SUFDRSx5QkFBQTtFQUNGO0FBQ0Y7O0FBRUE7RUFDRTtJQUNFLHdCQUFBO0lBQ0Esb0JBQUE7RUFBRjtFQUdBO0lBQ0UseUJBQUE7SUFDQSx3QkFBQTtFQURGO0VBSUE7SUFDRSx5QkFBQTtFQUZGO0FBQ0YiLCJmaWxlIjoibG9hZC1zcGlubmVyLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmxvYWQtc3Bpbm5lciBzdmcge1xyXG4gIHdpZHRoOiAzLjc1ZW07XHJcbiAgdHJhbnNmb3JtLW9yaWdpbjogY2VudGVyO1xyXG4gIGFuaW1hdGlvbjogcm90YXRlIDJzIGxpbmVhciBpbmZpbml0ZTtcclxufVxyXG5cclxuLmxvYWQtc3Bpbm5lciBjaXJjbGUge1xyXG4gIGZpbGw6IG5vbmU7XHJcbiAgc3Ryb2tlOiAjNjNiNmRjO1xyXG4gIHN0cm9rZS13aWR0aDogMztcclxuICBzdHJva2UtZGFzaGFycmF5OiAxLCAyMDA7XHJcbiAgc3Ryb2tlLWRhc2hvZmZzZXQ6IDA7XHJcbiAgc3Ryb2tlLWxpbmVjYXA6IHJvdW5kO1xyXG4gIGFuaW1hdGlvbjogZGFzaCAxLjVzIGVhc2UtaW4tb3V0IGluZmluaXRlO1xyXG59XHJcblxyXG5Aa2V5ZnJhbWVzIHJvdGF0ZSB7XHJcbiAgMTAwJSB7XHJcbiAgICB0cmFuc2Zvcm06IHJvdGF0ZSgzNjBkZWcpO1xyXG4gIH1cclxufVxyXG5cclxuQGtleWZyYW1lcyBkYXNoIHtcclxuICAwJSB7XHJcbiAgICBzdHJva2UtZGFzaGFycmF5OiAxLCAyMDA7XHJcbiAgICBzdHJva2UtZGFzaG9mZnNldDogMDtcclxuICB9XHJcblxyXG4gIDUwJSB7XHJcbiAgICBzdHJva2UtZGFzaGFycmF5OiA5MCwgMjAwO1xyXG4gICAgc3Ryb2tlLWRhc2hvZmZzZXQ6IC0zNXB4O1xyXG4gIH1cclxuXHJcbiAgMTAwJSB7XHJcbiAgICBzdHJva2UtZGFzaG9mZnNldDogLTEyNXB4O1xyXG4gIH1cclxufVxyXG4iXX0= */"]
      });
      /***/
    },

    /***/
    38965:
    /*!************************************************************!*\
      !*** ./src/app/shared/ngx-bottom-nav/bottom-nav.module.ts ***!
      \************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "BottomNavModule": function BottomNavModule() {
          return (
            /* binding */
            _BottomNavModule
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/common */
      38583);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var _components_bottom_nav_bottom_nav_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ./components/bottom-nav/bottom-nav.component */
      52601);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _BottomNavModule = /*#__PURE__*/_createClass(function _BottomNavModule() {
        _classCallCheck(this, _BottomNavModule);
      });

      _BottomNavModule.ɵfac = function BottomNavModule_Factory(t) {
        return new (t || _BottomNavModule)();
      };

      _BottomNavModule.ɵmod = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineNgModule"]({
        type: _BottomNavModule
      });
      _BottomNavModule.ɵinj = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjector"]({
        imports: [[_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterModule]]
      });

      (function () {
        (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsetNgModuleScope"](_BottomNavModule, {
          declarations: [_components_bottom_nav_bottom_nav_component__WEBPACK_IMPORTED_MODULE_0__.BottomNavComponent],
          imports: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterModule],
          exports: [_components_bottom_nav_bottom_nav_component__WEBPACK_IMPORTED_MODULE_0__.BottomNavComponent]
        });
      })();
      /***/

    },

    /***/
    52601:
    /*!*************************************************************************************!*\
      !*** ./src/app/shared/ngx-bottom-nav/components/bottom-nav/bottom-nav.component.ts ***!
      \*************************************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "BottomNavComponent": function BottomNavComponent() {
          return (
            /* binding */
            _BottomNavComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/router */
      39895);
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/common */
      38583);

      function BottomNavComponent_ng_container_1_Template(rf, ctx) {
        if (rf & 1) {
          var _r3 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵgetCurrentView"]();

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementContainerStart"](0);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "a", 2);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵlistener"]("click", function BottomNavComponent_ng_container_1_Template_a_click_1_listener() {
            var restoredCtx = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵrestoreView"](_r3);

            var item_r1 = restoredCtx.$implicit;

            var ctx_r2 = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵnextContext"]();

            return ctx_r2.navigate(item_r1.routerLink);
          });

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "span", 3);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](4, "span", 4);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](5);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementContainerEnd"]();
        }

        if (rf & 2) {
          var item_r1 = ctx.$implicit;

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵclassProp"]("mobile-nav-link--active", item_r1.active);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate1"](" ", item_r1.icon, " ");

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](2);

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtextInterpolate"](item_r1.label);
        }
      }
      /**
       * This component is a [Material-style bottom navigation bar]{@link https://material.io/design/components/bottom-navigation.html}.
       * It receives an array of [BottomNavItems]{@link BottomNavItem} in order to render navigation buttons.
       * With [Material theming]{@link https://github.com/latusinski/ngx-drawer-layout#enabling-material-theming}
       * enabled, this component changes its style, when the {@link color} property.
       */


      var _BottomNavComponent = /*#__PURE__*/function () {
        function _BottomNavComponent(router) {
          _classCallCheck(this, _BottomNavComponent);

          this.router = router;
          /**
           * Navigation items, which are rendered inside the navigation bar.
           */

          this.items = [];
        }

        _createClass(_BottomNavComponent, [{
          key: "colorPrimary",
          get: function get() {
            return this.color === 'primary';
          }
        }, {
          key: "accentPrimary",
          get: function get() {
            return this.color === 'accent';
          }
        }, {
          key: "warnPrimary",
          get: function get() {
            return this.color === 'warn';
          }
          /**
           * Returns true if the length of {@link items} is greater than 4, which hides labels on inactive items.
           */

        }, {
          key: "hideLabels",
          get: function get() {
            return this.items.length > 4;
          }
        }, {
          key: "navigate",
          value: function navigate(link) {
            this.router.navigateByUrl(link, {
              replaceUrl: true
            });
          }
        }]);

        return _BottomNavComponent;
      }();

      _BottomNavComponent.ɵfac = function BottomNavComponent_Factory(t) {
        return new (t || _BottomNavComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_1__.Router));
      };

      _BottomNavComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({
        type: _BottomNavComponent,
        selectors: [["ngx-bottom-nav"]],
        hostVars: 6,
        hostBindings: function BottomNavComponent_HostBindings(rf, ctx) {
          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵclassProp"]("color-primary", ctx.colorPrimary)("color-accent", ctx.accentPrimary)("color-warn", ctx.warnPrimary);
          }
        },
        inputs: {
          items: "items",
          color: "color"
        },
        decls: 2,
        vars: 1,
        consts: [[1, "mobile-nav"], [4, "ngFor", "ngForOf"], [1, "mobile-nav-link", 3, "click"], [1, "material-icons-round", "mobile-nav-icon"], [1, "mobile-nav-text"]],
        template: function BottomNavComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "nav", 0);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtemplate"](1, BottomNavComponent_ng_container_1_Template, 6, 4, "ng-container", 1);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
          }

          if (rf & 2) {
            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("ngForOf", ctx.items);
          }
        },
        directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.NgForOf],
        styles: [".mobile-nav[_ngcontent-%COMP%] {\n  position: fixed;\n  bottom: 0;\n  width: 100%;\n  height: 55px;\n  box-shadow: 0 0 3px rgba(0, 0, 0, 0.2);\n  background-color: #ffffff;\n  overflow-x: auto;\n}\n\n.mobile-nav-link[_ngcontent-%COMP%] {\n  display: inline-flex;\n  flex-direction: column;\n  align-items: center;\n  justify-content: center;\n  flex-grow: 1;\n  min-width: 20%;\n  overflow: hidden;\n  white-space: nowrap;\n  font-family: sans-serif;\n  font-size: 13px;\n  color: #444444;\n  text-decoration: none;\n  -webkit-tap-highlight-color: transparent;\n  transition: background-color 0.1s ease-in-out;\n}\n\n.mobile-nav-link[_ngcontent-%COMP%]:hover {\n  text-decoration: none;\n  color: #e96125;\n}\n\n.mobile-nav-link--active[_ngcontent-%COMP%] {\n  color: #e96125;\n  text-decoration: none;\n}\n\n.mobile-nav-icon[_ngcontent-%COMP%] {\n  font-size: 14pt !important;\n}\n\n.mobile-nav-text[_ngcontent-%COMP%] {\n  font-size: 8pt !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImJvdHRvbS1uYXYuY29tcG9uZW50LnNjc3MiLCIuLlxcLi5cXC4uXFwuLlxcLi5cXHN0eWxlc1xcX21peGlucy5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUNBO0VBQ0ksZUFBQTtFQUNBLFNBQUE7RUFDQSxXQUFBO0VBQ0EsWUFBQTtFQUNBLHNDQUFBO0VBQ0EseUJBQUE7RUFDQSxnQkFBQTtBQUFKOztBQUdBO0VBQ0ksb0JBQUE7RUFDQSxzQkFBQTtFQUNBLG1CQUFBO0VBQ0EsdUJBQUE7RUFDQSxZQUFBO0VBQ0EsY0FBQTtFQUNBLGdCQUFBO0VBQ0EsbUJBQUE7RUFDQSx1QkFBQTtFQUNBLGVBQUE7RUFDQSxjQUFBO0VBQ0EscUJBQUE7RUFDQSx3Q0FBQTtFQUNBLDZDQUFBO0FBQUo7O0FBR0E7RUFDSSxxQkFBQTtFQUNBLGNDOUJZO0FEOEJoQjs7QUFHQTtFQUNJLGNDbENZO0VEbUNaLHFCQUFBO0FBQUo7O0FBR0E7RUFDSSwwQkFBQTtBQUFKOztBQUdBO0VBQ0kseUJBQUE7QUFBSiIsImZpbGUiOiJib3R0b20tbmF2LmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiQGltcG9ydCAnX21peGlucyc7XHJcbi5tb2JpbGUtbmF2IHtcclxuICAgIHBvc2l0aW9uOiBmaXhlZDtcclxuICAgIGJvdHRvbTogMDtcclxuICAgIHdpZHRoOiAxMDAlO1xyXG4gICAgaGVpZ2h0OiA1NXB4O1xyXG4gICAgYm94LXNoYWRvdzogMCAwIDNweCByZ2JhKDAsIDAsIDAsIDAuMik7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjZmZmZmZmO1xyXG4gICAgb3ZlcmZsb3cteDogYXV0bztcclxufVxyXG5cclxuLm1vYmlsZS1uYXYtbGluayB7XHJcbiAgICBkaXNwbGF5OiBpbmxpbmUtZmxleDtcclxuICAgIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XHJcbiAgICBhbGlnbi1pdGVtczogY2VudGVyO1xyXG4gICAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XHJcbiAgICBmbGV4LWdyb3c6IDE7XHJcbiAgICBtaW4td2lkdGg6IDIwJTtcclxuICAgIG92ZXJmbG93OiBoaWRkZW47XHJcbiAgICB3aGl0ZS1zcGFjZTogbm93cmFwO1xyXG4gICAgZm9udC1mYW1pbHk6IHNhbnMtc2VyaWY7XHJcbiAgICBmb250LXNpemU6IDEzcHg7XHJcbiAgICBjb2xvcjogIzQ0NDQ0NDtcclxuICAgIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcclxuICAgIC13ZWJraXQtdGFwLWhpZ2hsaWdodC1jb2xvcjogdHJhbnNwYXJlbnQ7XHJcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kLWNvbG9yIDAuMXMgZWFzZS1pbi1vdXQ7XHJcbn1cclxuXHJcbi5tb2JpbGUtbmF2LWxpbms6aG92ZXIge1xyXG4gICAgdGV4dC1kZWNvcmF0aW9uOiBub25lO1xyXG4gICAgY29sb3I6ICRwcmltYXJ5LWNvbG9yO1xyXG59XHJcblxyXG4ubW9iaWxlLW5hdi1saW5rLS1hY3RpdmUge1xyXG4gICAgY29sb3I6ICRwcmltYXJ5LWNvbG9yO1xyXG4gICAgdGV4dC1kZWNvcmF0aW9uOiBub25lO1xyXG59XHJcblxyXG4ubW9iaWxlLW5hdi1pY29uIHtcclxuICAgIGZvbnQtc2l6ZTogMTRwdCAhaW1wb3J0YW50O1xyXG59XHJcblxyXG4ubW9iaWxlLW5hdi10ZXh0IHtcclxuICAgIGZvbnQtc2l6ZTogOHB0ICFpbXBvcnRhbnQ7XHJcbn1cclxuIiwiJHByaW1hcnktY29sb3I6ICNlOTYxMjU7XHJcbiRwcmltYXJ5LWZvbnQ6ICdQb3BwaW5zJyxcclxuc2Fucy1zZXJpZjtcclxuJHNlY29uZGFyeS1jb2xvcjogIzMyOTIyNTtcclxuJHNlY29uZC1ncmVlbjogIzNmYmY2MjtcclxuJHByaW1lLXJlZDogI2Q0M2IwYyAhaW1wb3J0YW50O1xyXG4kb2ZmLWNvbG9yOiAjNzE3MTcxO1xyXG4iXX0= */"]
      });
      /***/
    },

    /***/
    1650:
    /*!*********************************************************!*\
      !*** ./src/app/shared/not-found/not-found.component.ts ***!
      \*********************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "NotFoundComponent": function NotFoundComponent() {
          return (
            /* binding */
            _NotFoundComponent
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _NotFoundComponent = /*#__PURE__*/function () {
        function _NotFoundComponent() {
          _classCallCheck(this, _NotFoundComponent);
        }

        _createClass(_NotFoundComponent, [{
          key: "ngOnInit",
          value: function ngOnInit() {}
        }]);

        return _NotFoundComponent;
      }();

      _NotFoundComponent.ɵfac = function NotFoundComponent_Factory(t) {
        return new (t || _NotFoundComponent)();
      };

      _NotFoundComponent.ɵcmp = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({
        type: _NotFoundComponent,
        selectors: [["app-not-found"]],
        decls: 2,
        vars: 0,
        template: function NotFoundComponent_Template(rf, ctx) {
          if (rf & 1) {
            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "not-found works!");

            _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
          }
        },
        styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJub3QtZm91bmQuY29tcG9uZW50LnNjc3MifQ== */"]
      });
      /***/
    },

    /***/
    70404:
    /*!***********************************************!*\
      !*** ./src/app/shared/pipes/decimal-pipes.ts ***!
      \***********************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "RemoveCommaPipe": function RemoveCommaPipe() {
          return (
            /* binding */
            _RemoveCommaPipe
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _RemoveCommaPipe = /*#__PURE__*/function () {
        function _RemoveCommaPipe() {
          _classCallCheck(this, _RemoveCommaPipe);
        }

        _createClass(_RemoveCommaPipe, [{
          key: "transform",
          value: function transform(value) {
            var str = value != null ? value + "" : "";

            if (value !== undefined && value !== null) {
              return str.replace(/,/g, "");
            } else {
              return "";
            }
          }
        }]);

        return _RemoveCommaPipe;
      }();

      _RemoveCommaPipe.ɵfac = function RemoveCommaPipe_Factory(t) {
        return new (t || _RemoveCommaPipe)();
      };

      _RemoveCommaPipe.ɵpipe = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefinePipe"]({
        name: "removeComma",
        type: _RemoveCommaPipe,
        pure: true
      });
      /***/
    },

    /***/
    95731:
    /*!**************************************************************!*\
      !*** ./src/app/shared/services/error-interceptor.service.ts ***!
      \**************************************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "DrawerFor": function DrawerFor() {
          return (
            /* binding */
            _DrawerFor
          );
        },

        /* harmony export */
        "ErrorInterceptorService": function ErrorInterceptorService() {
          return (
            /* binding */
            _ErrorInterceptorService
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var rxjs__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! rxjs */
      79765);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var _DrawerFor;

      (function (DrawerFor) {
        DrawerFor[DrawerFor["Navigation"] = 1] = "Navigation";
      })(_DrawerFor || (_DrawerFor = {}));

      var _ErrorInterceptorService = /*#__PURE__*/_createClass(function _ErrorInterceptorService() {
        _classCallCheck(this, _ErrorInterceptorService);

        this.httpErrorOccurred = new rxjs__WEBPACK_IMPORTED_MODULE_0__.Subject();
        this.httpError$ = this.httpErrorOccurred.asObservable();
      });

      _ErrorInterceptorService.ɵfac = function ErrorInterceptorService_Factory(t) {
        return new (t || _ErrorInterceptorService)();
      };

      _ErrorInterceptorService.ɵprov = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({
        token: _ErrorInterceptorService,
        factory: _ErrorInterceptorService.ɵfac,
        providedIn: 'root'
      });
      /***/
    },

    /***/
    44466:
    /*!*****************************************!*\
      !*** ./src/app/shared/shared.module.ts ***!
      \*****************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "SharedModule": function SharedModule() {
          return (
            /* binding */
            _SharedModule
          );
        }
        /* harmony export */

      });
      /* harmony import */


      var _angular_common__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(
      /*! @angular/common */
      38583);
      /* harmony import */


      var _not_found_not_found_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ./not-found/not-found.component */
      1650);
      /* harmony import */


      var _activity_activity_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./activity/activity.component */
      1592);
      /* harmony import */


      var _layout_layout_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! ./layout/layout.component */
      61184);
      /* harmony import */


      var _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! ./load-spinner/load-spinner.component */
      10575);
      /* harmony import */


      var _angular_forms__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(
      /*! @angular/forms */
      3679);
      /* harmony import */


      var _auth_login_login_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(
      /*! ../auth/login/login.component */
      78146);
      /* harmony import */


      var _auth_logout_logout_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(
      /*! ../auth/logout/logout.component */
      28564);
      /* harmony import */


      var _directives_scroll_end__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(
      /*! ./directives/scroll-end */
      80552);
      /* harmony import */


      var _banner_image_carousel_banner_image_carousel_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(
      /*! ./banner-image-carousel/banner-image-carousel.component */
      96196);
      /* harmony import */


      var _ngx_bottom_nav_bottom_nav_module__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(
      /*! ./ngx-bottom-nav/bottom-nav.module */
      38965);
      /* harmony import */


      var _angular_common_http__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(
      /*! @angular/common/http */
      91841);
      /* harmony import */


      var ngx_spinner__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(
      /*! ngx-spinner */
      79866);
      /* harmony import */


      var _auth_two_factor_two_factor_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(
      /*! ../auth/two-factor/two-factor.component */
      51228);
      /* harmony import */


      var _pipes_decimal_pipes__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(
      /*! ./pipes/decimal-pipes */
      70404);
      /* harmony import */


      var angular_notifier__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(
      /*! angular-notifier */
      98609);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(
      /*! @angular/core */
      37716);

      var customNotifierOptions = {
        position: {
          horizontal: {
            position: 'middle',
            distance: 12
          },
          vertical: {
            position: 'bottom',
            distance: 30,
            gap: 30
          }
        },
        theme: 'material',
        behaviour: {
          autoHide: 500000,
          onClick: 'hide',
          onMouseover: 'pauseAutoHide',
          showDismissButton: true,
          stacking: 4
        },
        animations: {
          enabled: true,
          show: {
            preset: 'slide',
            speed: 300,
            easing: 'ease'
          },
          hide: {
            preset: 'fade',
            speed: 300,
            easing: 'ease',
            offset: 50
          },
          shift: {
            speed: 300,
            easing: 'ease'
          },
          overlap: 150
        }
      };

      var _SharedModule = /*#__PURE__*/_createClass(function _SharedModule() {
        _classCallCheck(this, _SharedModule);
      });

      _SharedModule.ɵfac = function SharedModule_Factory(t) {
        return new (t || _SharedModule)();
      };

      _SharedModule.ɵmod = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineNgModule"]({
        type: _SharedModule
      });
      _SharedModule.ɵinj = /*@__PURE__*/_angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵdefineInjector"]({
        imports: [[_angular_common__WEBPACK_IMPORTED_MODULE_12__.CommonModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _ngx_bottom_nav_bottom_nav_module__WEBPACK_IMPORTED_MODULE_8__.BottomNavModule, //NgxUsefulSwiperModule,
        _angular_common_http__WEBPACK_IMPORTED_MODULE_14__.HttpClientModule, ngx_spinner__WEBPACK_IMPORTED_MODULE_15__.NgxSpinnerModule, angular_notifier__WEBPACK_IMPORTED_MODULE_16__.NotifierModule.withConfig(customNotifierOptions) // NgQrScannerModule,
        // QRCodeModule,
        ], _angular_common_http__WEBPACK_IMPORTED_MODULE_14__.HttpClientModule, _angular_common__WEBPACK_IMPORTED_MODULE_12__.CommonModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _ngx_bottom_nav_bottom_nav_module__WEBPACK_IMPORTED_MODULE_8__.BottomNavModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, //NgxUsefulSwiperModule,
        angular_notifier__WEBPACK_IMPORTED_MODULE_16__.NotifierModule, ngx_spinner__WEBPACK_IMPORTED_MODULE_15__.NgxSpinnerModule]
      });

      (function () {
        (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_11__["ɵɵsetNgModuleScope"](_SharedModule, {
          declarations: [_not_found_not_found_component__WEBPACK_IMPORTED_MODULE_0__.NotFoundComponent, _activity_activity_component__WEBPACK_IMPORTED_MODULE_1__.ActivityComponent, _layout_layout_component__WEBPACK_IMPORTED_MODULE_2__.LayoutComponent, _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_3__.LoadSpinnerComponent, _auth_login_login_component__WEBPACK_IMPORTED_MODULE_4__.LoginComponent, _auth_two_factor_two_factor_component__WEBPACK_IMPORTED_MODULE_9__.TwoFactorComponent, _auth_logout_logout_component__WEBPACK_IMPORTED_MODULE_5__.LogoutComponent, _activity_activity_component__WEBPACK_IMPORTED_MODULE_1__.ActivityComponent, _directives_scroll_end__WEBPACK_IMPORTED_MODULE_6__.ScrollEndDirective, _pipes_decimal_pipes__WEBPACK_IMPORTED_MODULE_10__.RemoveCommaPipe, _banner_image_carousel_banner_image_carousel_component__WEBPACK_IMPORTED_MODULE_7__.BannerImageCarouselComponent],
          imports: [_angular_common__WEBPACK_IMPORTED_MODULE_12__.CommonModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _ngx_bottom_nav_bottom_nav_module__WEBPACK_IMPORTED_MODULE_8__.BottomNavModule, //NgxUsefulSwiperModule,
          _angular_common_http__WEBPACK_IMPORTED_MODULE_14__.HttpClientModule, ngx_spinner__WEBPACK_IMPORTED_MODULE_15__.NgxSpinnerModule, angular_notifier__WEBPACK_IMPORTED_MODULE_16__.NotifierModule],
          exports: [_activity_activity_component__WEBPACK_IMPORTED_MODULE_1__.ActivityComponent, _angular_common_http__WEBPACK_IMPORTED_MODULE_14__.HttpClientModule, _angular_common__WEBPACK_IMPORTED_MODULE_12__.CommonModule, _layout_layout_component__WEBPACK_IMPORTED_MODULE_2__.LayoutComponent, _banner_image_carousel_banner_image_carousel_component__WEBPACK_IMPORTED_MODULE_7__.BannerImageCarouselComponent, _auth_login_login_component__WEBPACK_IMPORTED_MODULE_4__.LoginComponent, _pipes_decimal_pipes__WEBPACK_IMPORTED_MODULE_10__.RemoveCommaPipe, _auth_two_factor_two_factor_component__WEBPACK_IMPORTED_MODULE_9__.TwoFactorComponent, // NgQrScannerModule,
          // QRCodeModule,
          _activity_activity_component__WEBPACK_IMPORTED_MODULE_1__.ActivityComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _ngx_bottom_nav_bottom_nav_module__WEBPACK_IMPORTED_MODULE_8__.BottomNavModule, _load_spinner_load_spinner_component__WEBPACK_IMPORTED_MODULE_3__.LoadSpinnerComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.FormsModule, _angular_forms__WEBPACK_IMPORTED_MODULE_13__.ReactiveFormsModule, _directives_scroll_end__WEBPACK_IMPORTED_MODULE_6__.ScrollEndDirective, //NgxUsefulSwiperModule,
          angular_notifier__WEBPACK_IMPORTED_MODULE_16__.NotifierModule, ngx_spinner__WEBPACK_IMPORTED_MODULE_15__.NgxSpinnerModule]
        });
      })();
      /***/

    },

    /***/
    92340:
    /*!*****************************************!*\
      !*** ./src/environments/environment.ts ***!
      \*****************************************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony export */


      __webpack_require__.d(__webpack_exports__, {
        /* harmony export */
        "environment": function environment() {
          return (
            /* binding */
            _environment
          );
        }
        /* harmony export */

      }); // This file can be replaced during build by using the `fileReplacements` array.
      // `ng build` replaces `environment.ts` with `environment.prod.ts`.
      // The list of file replacements can be found in `angular.json`.


      var _environment = {
        firebase: {
          projectId: 'xog-app',
          appId: '1:673895912821:web:35dd83c2011d49c6ff6f3c',
          storageBucket: 'xog-app.appspot.com',
          locationId: 'us-central',
          apiKey: 'AIzaSyC9v1_yLcS5F-gygLlhCzX6R23Mb66mnaE',
          authDomain: 'xog-app.firebaseapp.com',
          messagingSenderId: '673895912821',
          measurementId: 'G-E8YD0C5LZJ'
        },
        production: false,
        isDesktop: false,
        isMobileApp: false,
        appName: 'Xog',
        assetsUrl: '/assets',
        localAssetsUrl: '/assets/',
        uploadsUrl: "https://xog-app.azurewebsites.net/",
        imageUrl: '/Content/user/assets',
        apiUrl: 'https://xog-app.azurewebsites.net/api/',
        appAuthUrl: 'https://xog-app.azurewebsites.net/token',
        azureClientId: "f8af8402-0170-4cd1-9c57-1cc8680f1d17",
        azureAuthorization: "b1c28fc1-9a29-44ab-b406-84b796afa21c",
        firebaseConfig: {
          apiKey: "AIzaSyC9v1_yLcS5F-gygLlhCzX6R23Mb66mnaE",
          authDomain: "xog-app.firebaseapp.com",
          projectId: "xog-app",
          storageBucket: "xog-app.appspot.com",
          messagingSenderId: "673895912821",
          appId: "1:673895912821:web:35dd83c2011d49c6ff6f3c",
          measurementId: "G-E8YD0C5LZJ"
        },
        razorPayOptions: {
          "key": "rzp_test_jOS35pftXDE8SC",
          "amount": "",
          "currency": "INR",
          "name": "Modern Mart",
          "description": "",
          "image": "https://example.com/your_logo",
          "order_id": "",
          "handler": null,
          "prefill": {
            "name": "",
            "email": "",
            "contact": ""
          },
          "notes": {
            "address": ""
          },
          "theme": {
            "color": "#3399cc"
          }
        },
        wapid: {
          "publicKey": "BAOiL1h0ihuB10wS4hmfbaY8fQGfDr9JuKVOxn3CoPH_KJfGG1IKMwYIj7SDUan_DMsoePn6HbypqiV5gOU4CFo",
          "privateKey": "vcgcK30E5magMj-Y8SYBGlHxSHA3uxil2R31l_wMx2E"
        }
      };
      /*
       * For easier debugging in development mode, you can import the following file
       * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
       *
       * This import should be commented out in production mode because it will have a negative impact
       * on performance if an error is thrown.
       */
      // import 'zone.js/plugins/zone-error';  // Included with Angular CLI.

      /***/
    },

    /***/
    14431:
    /*!*********************!*\
      !*** ./src/main.ts ***!
      \*********************/

    /***/
    function _(__unused_webpack_module, __webpack_exports__, __webpack_require__) {
      "use strict";

      __webpack_require__.r(__webpack_exports__);
      /* harmony import */


      var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
      /*! @angular/platform-browser */
      39075);
      /* harmony import */


      var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
      /*! @angular/core */
      37716);
      /* harmony import */


      var _app_app_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
      /*! ./app/app.module */
      36747);
      /* harmony import */


      var _environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
      /*! ./environments/environment */
      92340);

      if (_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.production) {
        (0, _angular_core__WEBPACK_IMPORTED_MODULE_2__.enableProdMode)();
      }

      _angular_platform_browser__WEBPACK_IMPORTED_MODULE_3__.platformBrowser().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_0__.AppModule)["catch"](function (err) {
        return console.error(err);
      });
      /***/

    }
  },
  /******/
  function (__webpack_require__) {
    // webpackRuntimeModules

    /******/
    "use strict";
    /******/

    /******/

    var __webpack_exec__ = function __webpack_exec__(moduleId) {
      return __webpack_require__(__webpack_require__.s = moduleId);
    };
    /******/


    __webpack_require__.O(0, ["vendor"], function () {
      return __webpack_exec__(14431);
    });
    /******/


    var __webpack_exports__ = __webpack_require__.O();
    /******/

  }]);
})();
//# sourceMappingURL=main-es5.js.map