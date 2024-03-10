(self["webpackChunkxog_admin"] = self["webpackChunkxog_admin"] || []).push([["main"],{

/***/ 8255:
/*!*******************************************************!*\
  !*** ./$_lazy_route_resources/ lazy namespace object ***!
  \*******************************************************/
/***/ ((module) => {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(() => {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = () => ([]);
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = 8255;
module.exports = webpackEmptyAsyncContext;

/***/ }),

/***/ 158:
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppRoutingModule": () => (/* binding */ AppRoutingModule),
/* harmony export */   "routingComponents": () => (/* binding */ routingComponents)
/* harmony export */ });
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_61__ = __webpack_require__(/*! @angular/router */ 9895);
/* harmony import */ var _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./views/add-brand/add-brand.component */ 6679);
/* harmony import */ var _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./views/add-category/add-category.component */ 3478);
/* harmony import */ var _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./views/add-offers/add-offers.component */ 707);
/* harmony import */ var _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./views/add-products/add-products.component */ 8713);
/* harmony import */ var _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./views/add-sub/add-sub.component */ 2286);
/* harmony import */ var _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./views/add-users/add-users.component */ 7151);
/* harmony import */ var _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./views/add-wallet/add-wallet.component */ 7197);
/* harmony import */ var _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./views/brands/brands.component */ 7419);
/* harmony import */ var _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./views/categories/categories.component */ 7290);
/* harmony import */ var _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./views/customers/customers.component */ 6510);
/* harmony import */ var _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./views/finance-stats/finance-stats.component */ 1331);
/* harmony import */ var _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./auth/forgetpassword/forgetpassword.component */ 7412);
/* harmony import */ var _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./views/dashboard/dashboard.component */ 6101);
/* harmony import */ var _auth_login_login_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./auth/login/login.component */ 8146);
/* harmony import */ var _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./views/offers/offers.component */ 7584);
/* harmony import */ var _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./views/orders/orders.component */ 7232);
/* harmony import */ var _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./views/payment-history/payment-history.component */ 8570);
/* harmony import */ var _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./views/payment-requests/payment-requests.component */ 1706);
/* harmony import */ var _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./auth/phoneotp/phoneotp.component */ 5180);
/* harmony import */ var _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./views/products-csv/products-csv.component */ 4157);
/* harmony import */ var _views_products_products_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./views/products/products.component */ 3119);
/* harmony import */ var _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./views/refund/refund.component */ 9418);
/* harmony import */ var _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./views/return-orders/return-orders.component */ 3780);
/* harmony import */ var _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./views/sub-categories/sub-categories.component */ 1099);
/* harmony import */ var _views_users_users_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./views/users/users.component */ 7623);
/* harmony import */ var _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! ./views/wallet-history/wallet-history.component */ 2589);
/* harmony import */ var _components_sidenavbar_sidenavbar_component__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! ./components/sidenavbar/sidenavbar.component */ 5536);
/* harmony import */ var _components_topnav_topnav_component__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./components/topnav/topnav.component */ 6801);
/* harmony import */ var _layouts_auth_layout_auth_layout_component__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./layouts/auth-layout/auth-layout.component */ 8371);
/* harmony import */ var _layouts_main_layout_main_layout_component__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./layouts/main-layout/main-layout.component */ 4805);
/* harmony import */ var _auth_helpers_role_guard__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! ./auth/_helpers/role.guard */ 9757);
/* harmony import */ var _auth_models_role__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! ./auth/_models/role */ 4621);
/* harmony import */ var _views_product_group_product_groups_component__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! ./views/product-group/product-groups.component */ 8624);
/* harmony import */ var _views_add_product_group_add_prodouct_group_component__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! ./views/add-product-group/add-prodouct-group.component */ 9155);
/* harmony import */ var _views_settings_settings_component__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! ./views/settings/settings.component */ 4988);
/* harmony import */ var _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! ./views/settings/quantity-measures/quantity-measures.component */ 7592);
/* harmony import */ var _views_settings_setting_default_setting_default_component__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! ./views/settings/setting-default/setting-default.component */ 9945);
/* harmony import */ var _views_settings_taxes_taxes_component__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! ./views/settings/taxes/taxes.component */ 1154);
/* harmony import */ var _views_settings_delivery_charges_delivery_charges_component__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ./views/settings/delivery-charges/delivery-charges.component */ 3666);
/* harmony import */ var _views_manage_shared_manage_shared_component__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./views/manage-shared/manage-shared.component */ 7619);
/* harmony import */ var _views_manage_home_banner_manage_home_banner_component__WEBPACK_IMPORTED_MODULE_40__ = __webpack_require__(/*! ./views/manage-home-banner/manage-home-banner.component */ 4696);
/* harmony import */ var _views_manage_featured_list_manage_featured_list_component__WEBPACK_IMPORTED_MODULE_41__ = __webpack_require__(/*! ./views/manage-featured-list/manage-featured-list.component */ 6636);
/* harmony import */ var _views_manage_top_brands_manage_top_brands_component__WEBPACK_IMPORTED_MODULE_42__ = __webpack_require__(/*! ./views/manage-top-brands/manage-top-brands.component */ 9950);
/* harmony import */ var _views_manage_mobile_manage_mobile_component__WEBPACK_IMPORTED_MODULE_43__ = __webpack_require__(/*! ./views/manage-mobile/manage-mobile.component */ 6601);
/* harmony import */ var _views_slider_banners_slider_banners_component__WEBPACK_IMPORTED_MODULE_44__ = __webpack_require__(/*! ./views/slider-banners/slider-banners.component */ 8827);
/* harmony import */ var _views_add_slider_banner_add_slider_banner_component__WEBPACK_IMPORTED_MODULE_45__ = __webpack_require__(/*! ./views/add-slider-banner/add-slider-banner.component */ 714);
/* harmony import */ var _views_mobile_custom_offer_mobile_custom_offer_component__WEBPACK_IMPORTED_MODULE_46__ = __webpack_require__(/*! ./views/mobile-custom-offer/mobile-custom-offer.component */ 5267);
/* harmony import */ var _views_manage_desktop_manage_desktop_component__WEBPACK_IMPORTED_MODULE_47__ = __webpack_require__(/*! ./views/manage-desktop/manage-desktop.component */ 6038);
/* harmony import */ var _views_four_banners_four_banners_component__WEBPACK_IMPORTED_MODULE_48__ = __webpack_require__(/*! ./views/four-banners/four-banners.component */ 9899);
/* harmony import */ var _views_add_fourbanners_add_fourbanners_component__WEBPACK_IMPORTED_MODULE_49__ = __webpack_require__(/*! ./views/add-fourbanners/add-fourbanners.component */ 4570);
/* harmony import */ var _views_offer_lists_offer_lists_component__WEBPACK_IMPORTED_MODULE_50__ = __webpack_require__(/*! ./views/offer-lists/offer-lists.component */ 3711);
/* harmony import */ var _views_add_offer_list_add_offer_list_component__WEBPACK_IMPORTED_MODULE_51__ = __webpack_require__(/*! ./views/add-offer-list/add-offer-list.component */ 3062);
/* harmony import */ var _views_settings_delivery_timings_delivery_timings_component__WEBPACK_IMPORTED_MODULE_52__ = __webpack_require__(/*! ./views/settings/delivery-timings/delivery-timings.component */ 1529);
/* harmony import */ var _views_settings_timing_details_timing_details_component__WEBPACK_IMPORTED_MODULE_53__ = __webpack_require__(/*! ./views/settings/timing-details/timing-details.component */ 6344);
/* harmony import */ var _desktop_reports_customer_order_customer_order_component__WEBPACK_IMPORTED_MODULE_54__ = __webpack_require__(/*! ./desktop/reports/customer-order/customer-order.component */ 202);
/* harmony import */ var _desktop_reports_sales_reports_sales_reports_component__WEBPACK_IMPORTED_MODULE_55__ = __webpack_require__(/*! ./desktop/reports/sales-reports/sales-reports.component */ 2061);
/* harmony import */ var _desktop_reports_product_reports_product_reports_component__WEBPACK_IMPORTED_MODULE_56__ = __webpack_require__(/*! ./desktop/reports/product-reports/product-reports.component */ 1225);
/* harmony import */ var _desktop_reports_customer_reports_customer_reports_component__WEBPACK_IMPORTED_MODULE_57__ = __webpack_require__(/*! ./desktop/reports/customer-reports/customer-reports.component */ 4649);
/* harmony import */ var _desktop_reports_brand_reports_brand_reports_component__WEBPACK_IMPORTED_MODULE_58__ = __webpack_require__(/*! ./desktop/reports/brand-reports/brand-reports.component */ 5085);
/* harmony import */ var _desktop_reports_trans_reports_trans_reports_component__WEBPACK_IMPORTED_MODULE_59__ = __webpack_require__(/*! ./desktop/reports/trans-reports/trans-reports.component */ 1823);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_60__ = __webpack_require__(/*! @angular/core */ 7716);































































const routes = [
    {
        path: '', component: _layouts_main_layout_main_layout_component__WEBPACK_IMPORTED_MODULE_29__.MainLayoutComponent,
        canActivate: [_auth_helpers_role_guard__WEBPACK_IMPORTED_MODULE_30__.RoleGuardService],
        data: { roles: [_auth_models_role__WEBPACK_IMPORTED_MODULE_31__.Role.Admin] },
        children: [
            { path: '', component: _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_12__.DashboardComponent },
            { path: 'dashboard', redirectTo: '' },
            { path: 'orders', component: _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_15__.OrdersComponent },
            { path: 'returns', component: _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_22__.ReturnOrdersComponent },
            { path: 'refunds', component: _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_21__.RefundComponent },
            { path: 'customers', component: _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__.CustomersComponent },
            { path: 'products', component: _views_products_products_component__WEBPACK_IMPORTED_MODULE_20__.ProductsComponent },
            { path: 'products/add', component: _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_3__.AddProductsComponent },
            { path: 'products/edit/:id', component: _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_3__.AddProductsComponent },
            { path: 'upload-csv', component: _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_19__.ProductsCsvComponent },
            { path: 'categories', component: _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_8__.CategoriesComponent },
            { path: 'categories/add', component: _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_1__.AddCategoryComponent },
            { path: 'categories/edit/:id', component: _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_1__.AddCategoryComponent },
            { path: 'sub-categories', component: _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_23__.SubCategoriesComponent },
            { path: 'sub-categories/add', component: _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_4__.AddSubComponent },
            { path: 'sub-categories/edit/:id', component: _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_4__.AddSubComponent },
            { path: 'product-groups', component: _views_product_group_product_groups_component__WEBPACK_IMPORTED_MODULE_32__.ProductGroupsComponent },
            { path: 'product-groups/add', component: _views_add_product_group_add_prodouct_group_component__WEBPACK_IMPORTED_MODULE_33__.AddProductGroupComponent },
            { path: 'product-groups/edit/:id', component: _views_add_product_group_add_prodouct_group_component__WEBPACK_IMPORTED_MODULE_33__.AddProductGroupComponent },
            { path: 'brands', component: _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_7__.BrandsComponent },
            { path: 'brands/add', component: _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_0__.AddBrandComponent },
            { path: 'brands/edit/:id', component: _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_0__.AddBrandComponent },
            { path: 'offers', component: _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_14__.OffersComponent },
            { path: 'offers/add', component: _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_2__.AddOffersComponent },
            { path: 'offers/edit/:id', component: _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_2__.AddOffersComponent },
            { path: 'users', component: _views_users_users_component__WEBPACK_IMPORTED_MODULE_24__.UsersComponent },
            { path: 'users/add', component: _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_5__.AddUsersComponent },
            { path: 'users/edit/:id', component: _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_5__.AddUsersComponent },
            { path: 'payment-history', component: _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_16__.PaymentHistoryComponent },
            { path: 'wallet-history', component: _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_25__.WalletHistoryComponent },
            { path: 'payment-request', component: _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_17__.PaymentRequestsComponent },
            { path: 'add-wallet', component: _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_6__.AddWalletComponent },
            { path: 'finance', component: _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_10__.FinanceStatsComponent },
            { path: 'finance-stats', component: _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_10__.FinanceStatsComponent },
            { path: 'manage-shared', component: _views_manage_shared_manage_shared_component__WEBPACK_IMPORTED_MODULE_39__.ManageSharedComponent },
            { path: 'manage-homebanner', component: _views_manage_home_banner_manage_home_banner_component__WEBPACK_IMPORTED_MODULE_40__.ManageHomeBannerComponent },
            { path: 'featured-lists', component: _views_manage_featured_list_manage_featured_list_component__WEBPACK_IMPORTED_MODULE_41__.ManageFeaturedListComponent },
            { path: 'manage-topbrands', component: _views_manage_top_brands_manage_top_brands_component__WEBPACK_IMPORTED_MODULE_42__.ManageTopBrandsComponent },
            { path: 'manage-mobile', component: _views_manage_mobile_manage_mobile_component__WEBPACK_IMPORTED_MODULE_43__.ManageMobileComponent },
            { path: 'slider-banner', component: _views_slider_banners_slider_banners_component__WEBPACK_IMPORTED_MODULE_44__.SliderBannersComponent },
            { path: 'add-sliderbanner', component: _views_add_slider_banner_add_slider_banner_component__WEBPACK_IMPORTED_MODULE_45__.AddSliderBannerComponent },
            { path: 'mobile-custom-offer', component: _views_mobile_custom_offer_mobile_custom_offer_component__WEBPACK_IMPORTED_MODULE_46__.MobileCustomOfferComponent },
            { path: 'manage-desktop', component: _views_manage_desktop_manage_desktop_component__WEBPACK_IMPORTED_MODULE_47__.ManageDesktopComponent },
            { path: 'four-banners', component: _views_four_banners_four_banners_component__WEBPACK_IMPORTED_MODULE_48__.FourBannersComponent },
            { path: 'add-fourbanners', component: _views_add_fourbanners_add_fourbanners_component__WEBPACK_IMPORTED_MODULE_49__.AddFourbannersComponent },
            { path: 'offer-lists', component: _views_offer_lists_offer_lists_component__WEBPACK_IMPORTED_MODULE_50__.OfferListsComponent },
            { path: 'offer-lists/add', component: _views_add_offer_list_add_offer_list_component__WEBPACK_IMPORTED_MODULE_51__.AddOfferListComponent },
            { path: 'offer-lists/edit/:id', component: _views_add_offer_list_add_offer_list_component__WEBPACK_IMPORTED_MODULE_51__.AddOfferListComponent },
            { path: 'co-reports', component: _desktop_reports_customer_order_customer_order_component__WEBPACK_IMPORTED_MODULE_54__.CustomerOrderComponent },
            { path: 'sales-reports', component: _desktop_reports_sales_reports_sales_reports_component__WEBPACK_IMPORTED_MODULE_55__.SalesReportsComponent },
            { path: 'product-reports', component: _desktop_reports_product_reports_product_reports_component__WEBPACK_IMPORTED_MODULE_56__.ProductReportsComponent },
            { path: 'customer-reports', component: _desktop_reports_customer_reports_customer_reports_component__WEBPACK_IMPORTED_MODULE_57__.CustomerReportsComponent },
            { path: 'brand-reports', component: _desktop_reports_brand_reports_brand_reports_component__WEBPACK_IMPORTED_MODULE_58__.BrandReportsComponent },
            { path: 'trans-reports', component: _desktop_reports_trans_reports_trans_reports_component__WEBPACK_IMPORTED_MODULE_59__.TransReportsComponent },
            {
                path: 'settings', component: _views_settings_settings_component__WEBPACK_IMPORTED_MODULE_34__.SettingsComponent,
                children: [
                    { path: '', component: _views_settings_setting_default_setting_default_component__WEBPACK_IMPORTED_MODULE_36__.SettingDefaultComponent },
                    {
                        path: 'quantity-measures', component: _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_35__.QuantityMeasuresComponent,
                        children: [
                            { path: 'add', component: _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_35__.QuantityMeasuresComponent },
                            { path: 'edit/:id', component: _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_35__.QuantityMeasuresComponent }
                        ]
                    },
                    { path: 'taxes', component: _views_settings_taxes_taxes_component__WEBPACK_IMPORTED_MODULE_37__.TaxesComponent },
                    { path: 'delivery-charges', component: _views_settings_delivery_charges_delivery_charges_component__WEBPACK_IMPORTED_MODULE_38__.DeliveryChargesComponent },
                    {
                        path: 'delivery-timings', component: _views_settings_delivery_timings_delivery_timings_component__WEBPACK_IMPORTED_MODULE_52__.DeliveryTimingsComponent,
                        children: [{ path: ':day', component: _views_settings_timing_details_timing_details_component__WEBPACK_IMPORTED_MODULE_53__.TimingDetailsComponent }]
                    }
                ]
            },
            {
                path: '**', redirectTo: '/auth/login'
            }
        ]
    },
    {
        path: 'auth', component: _layouts_auth_layout_auth_layout_component__WEBPACK_IMPORTED_MODULE_28__.AuthLayoutComponent, children: [
            { path: '', redirectTo: 'login', pathMatch: "full" },
            { path: 'login', component: _auth_login_login_component__WEBPACK_IMPORTED_MODULE_13__.LoginComponent },
            { path: 'forgetpassword', component: _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_11__.ForgetpasswordComponent },
            { path: 'enter-otp', component: _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_18__.PhoneotpComponent },
        ]
    }
];
class AppRoutingModule {
}
AppRoutingModule.ɵfac = function AppRoutingModule_Factory(t) { return new (t || AppRoutingModule)(); };
AppRoutingModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_60__["ɵɵdefineNgModule"]({ type: AppRoutingModule });
AppRoutingModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_60__["ɵɵdefineInjector"]({ imports: [[_angular_router__WEBPACK_IMPORTED_MODULE_61__.RouterModule.forRoot(routes)], _angular_router__WEBPACK_IMPORTED_MODULE_61__.RouterModule] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_60__["ɵɵsetNgModuleScope"](AppRoutingModule, { imports: [_angular_router__WEBPACK_IMPORTED_MODULE_61__.RouterModule], exports: [_angular_router__WEBPACK_IMPORTED_MODULE_61__.RouterModule] }); })();
const routingComponents = [_auth_login_login_component__WEBPACK_IMPORTED_MODULE_13__.LoginComponent, _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_11__.ForgetpasswordComponent, _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_18__.PhoneotpComponent, _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_12__.DashboardComponent, _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_15__.OrdersComponent, _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_22__.ReturnOrdersComponent, _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_21__.RefundComponent, _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__.CustomersComponent, _views_products_products_component__WEBPACK_IMPORTED_MODULE_20__.ProductsComponent, _components_topnav_topnav_component__WEBPACK_IMPORTED_MODULE_27__.TopnavComponent, _components_sidenavbar_sidenavbar_component__WEBPACK_IMPORTED_MODULE_26__.SidenavbarComponent, _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_3__.AddProductsComponent, _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_19__.ProductsCsvComponent, _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_8__.CategoriesComponent, _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_1__.AddCategoryComponent, _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_23__.SubCategoriesComponent, _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_4__.AddSubComponent, _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_7__.BrandsComponent, _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_0__.AddBrandComponent, _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_14__.OffersComponent, _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_2__.AddOffersComponent, _views_users_users_component__WEBPACK_IMPORTED_MODULE_24__.UsersComponent, _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_5__.AddUsersComponent, _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_16__.PaymentHistoryComponent, _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_17__.PaymentRequestsComponent, _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_25__.WalletHistoryComponent, _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_6__.AddWalletComponent, _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_10__.FinanceStatsComponent];


/***/ }),

/***/ 5041:
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppComponent": () => (/* binding */ AppComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ 9895);
/* harmony import */ var ngx_spinner__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ngx-spinner */ 9866);
/* harmony import */ var angular_notifier__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! angular-notifier */ 8609);




class AppComponent {
    constructor() {
        this.title = 'xog-admin';
    }
}
AppComponent.ɵfac = function AppComponent_Factory(t) { return new (t || AppComponent)(); };
AppComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: AppComponent, selectors: [["app-root"]], decls: 5, vars: 1, consts: [["bdColor", "rgba(0, 0, 0, 0.8)", "size", "medium", "color", "#fff", "type", "ball-atom", 2, "z-index", "11111", 3, "fullScreen"], [2, "color", "white"]], template: function AppComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](0, "router-outlet");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "ngx-spinner", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](2, "p", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](3, " Loading... ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](4, "notifier-container");
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵproperty"]("fullScreen", true);


/***/ }),

/***/ 6747:
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppModule": () => (/* binding */ AppModule)
/* harmony export */ });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_68__ = __webpack_require__(/*! @angular/platform-browser */ 9075);
/* harmony import */ var ngx_daterangepicker_material__WEBPACK_IMPORTED_MODULE_71__ = __webpack_require__(/*! ngx-daterangepicker-material */ 5048);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_72__ = __webpack_require__(/*! @angular/forms */ 3679);
/* harmony import */ var _ng_select_ng_select__WEBPACK_IMPORTED_MODULE_69__ = __webpack_require__(/*! @ng-select/ng-select */ 6640);
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./app-routing.module */ 158);
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./app.component */ 5041);
/* harmony import */ var _auth_login_login_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./auth/login/login.component */ 8146);
/* harmony import */ var _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./auth/forgetpassword/forgetpassword.component */ 7412);
/* harmony import */ var _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./auth/phoneotp/phoneotp.component */ 5180);
/* harmony import */ var _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./views/dashboard/dashboard.component */ 6101);
/* harmony import */ var _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./views/orders/orders.component */ 7232);
/* harmony import */ var _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./views/return-orders/return-orders.component */ 3780);
/* harmony import */ var _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./views/refund/refund.component */ 9418);
/* harmony import */ var _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./views/customers/customers.component */ 6510);
/* harmony import */ var _views_products_products_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./views/products/products.component */ 3119);
/* harmony import */ var _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./views/add-products/add-products.component */ 8713);
/* harmony import */ var _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./views/products-csv/products-csv.component */ 4157);
/* harmony import */ var _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./views/categories/categories.component */ 7290);
/* harmony import */ var _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./views/add-category/add-category.component */ 3478);
/* harmony import */ var _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./views/sub-categories/sub-categories.component */ 1099);
/* harmony import */ var _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./views/add-sub/add-sub.component */ 2286);
/* harmony import */ var _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./views/brands/brands.component */ 7419);
/* harmony import */ var _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./views/add-brand/add-brand.component */ 6679);
/* harmony import */ var _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./views/offers/offers.component */ 7584);
/* harmony import */ var _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./views/add-offers/add-offers.component */ 707);
/* harmony import */ var _views_users_users_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./views/users/users.component */ 7623);
/* harmony import */ var _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./views/add-users/add-users.component */ 7151);
/* harmony import */ var _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./views/payment-history/payment-history.component */ 8570);
/* harmony import */ var _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./views/wallet-history/wallet-history.component */ 2589);
/* harmony import */ var _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! ./views/payment-requests/payment-requests.component */ 1706);
/* harmony import */ var _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! ./views/add-wallet/add-wallet.component */ 7197);
/* harmony import */ var _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./views/finance-stats/finance-stats.component */ 1331);
/* harmony import */ var _components_sidenavbar_sidenavbar_component__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! ./components/sidenavbar/sidenavbar.component */ 5536);
/* harmony import */ var _components_topnav_topnav_component__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! ./components/topnav/topnav.component */ 6801);
/* harmony import */ var _layouts_main_layout_main_layout_component__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! ./layouts/main-layout/main-layout.component */ 4805);
/* harmony import */ var _layouts_auth_layout_auth_layout_component__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! ./layouts/auth-layout/auth-layout.component */ 8371);
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_70__ = __webpack_require__(/*! @angular/platform-browser/animations */ 5835);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_67__ = __webpack_require__(/*! @angular/common/http */ 1841);
/* harmony import */ var _auth_helpers_jwt_interceptor__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! ./auth/_helpers/jwt.interceptor */ 4778);
/* harmony import */ var _auth_helpers_error_interceptor__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! ./auth/_helpers/error.interceptor */ 761);
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! ./shared/shared.module */ 4466);
/* harmony import */ var _views_product_group_product_groups_component__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! ./views/product-group/product-groups.component */ 8624);
/* harmony import */ var _views_add_product_group_add_prodouct_group_component__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! ./views/add-product-group/add-prodouct-group.component */ 9155);
/* harmony import */ var _views_settings_settings_component__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! ./views/settings/settings.component */ 4988);
/* harmony import */ var _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ./views/settings/quantity-measures/quantity-measures.component */ 7592);
/* harmony import */ var _views_settings_setting_default_setting_default_component__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./views/settings/setting-default/setting-default.component */ 9945);
/* harmony import */ var _views_settings_settings_nav_settings_nav_component__WEBPACK_IMPORTED_MODULE_40__ = __webpack_require__(/*! ./views/settings/settings-nav/settings-nav.component */ 646);
/* harmony import */ var _views_settings_taxes_taxes_component__WEBPACK_IMPORTED_MODULE_41__ = __webpack_require__(/*! ./views/settings/taxes/taxes.component */ 1154);
/* harmony import */ var _views_settings_delivery_charges_delivery_charges_component__WEBPACK_IMPORTED_MODULE_42__ = __webpack_require__(/*! ./views/settings/delivery-charges/delivery-charges.component */ 3666);
/* harmony import */ var _views_order_details_order_details_component__WEBPACK_IMPORTED_MODULE_43__ = __webpack_require__(/*! ./views/order-details/order-details.component */ 7168);
/* harmony import */ var _views_manage_shared_manage_shared_component__WEBPACK_IMPORTED_MODULE_44__ = __webpack_require__(/*! ./views/manage-shared/manage-shared.component */ 7619);
/* harmony import */ var _views_manage_home_banner_manage_home_banner_component__WEBPACK_IMPORTED_MODULE_45__ = __webpack_require__(/*! ./views/manage-home-banner/manage-home-banner.component */ 4696);
/* harmony import */ var _views_manage_featured_list_manage_featured_list_component__WEBPACK_IMPORTED_MODULE_46__ = __webpack_require__(/*! ./views/manage-featured-list/manage-featured-list.component */ 6636);
/* harmony import */ var _views_manage_top_brands_manage_top_brands_component__WEBPACK_IMPORTED_MODULE_47__ = __webpack_require__(/*! ./views/manage-top-brands/manage-top-brands.component */ 9950);
/* harmony import */ var _views_manage_mobile_manage_mobile_component__WEBPACK_IMPORTED_MODULE_48__ = __webpack_require__(/*! ./views/manage-mobile/manage-mobile.component */ 6601);
/* harmony import */ var _views_slider_banners_slider_banners_component__WEBPACK_IMPORTED_MODULE_49__ = __webpack_require__(/*! ./views/slider-banners/slider-banners.component */ 8827);
/* harmony import */ var _views_add_slider_banner_add_slider_banner_component__WEBPACK_IMPORTED_MODULE_50__ = __webpack_require__(/*! ./views/add-slider-banner/add-slider-banner.component */ 714);
/* harmony import */ var _views_mobile_custom_offer_mobile_custom_offer_component__WEBPACK_IMPORTED_MODULE_51__ = __webpack_require__(/*! ./views/mobile-custom-offer/mobile-custom-offer.component */ 5267);
/* harmony import */ var _views_manage_desktop_manage_desktop_component__WEBPACK_IMPORTED_MODULE_52__ = __webpack_require__(/*! ./views/manage-desktop/manage-desktop.component */ 6038);
/* harmony import */ var _views_four_banners_four_banners_component__WEBPACK_IMPORTED_MODULE_53__ = __webpack_require__(/*! ./views/four-banners/four-banners.component */ 9899);
/* harmony import */ var _views_add_fourbanners_add_fourbanners_component__WEBPACK_IMPORTED_MODULE_54__ = __webpack_require__(/*! ./views/add-fourbanners/add-fourbanners.component */ 4570);
/* harmony import */ var _views_offer_lists_offer_lists_component__WEBPACK_IMPORTED_MODULE_55__ = __webpack_require__(/*! ./views/offer-lists/offer-lists.component */ 3711);
/* harmony import */ var _views_add_offer_list_add_offer_list_component__WEBPACK_IMPORTED_MODULE_56__ = __webpack_require__(/*! ./views/add-offer-list/add-offer-list.component */ 3062);
/* harmony import */ var _views_settings_delivery_timings_delivery_timings_component__WEBPACK_IMPORTED_MODULE_57__ = __webpack_require__(/*! ./views/settings/delivery-timings/delivery-timings.component */ 1529);
/* harmony import */ var _views_settings_timing_details_timing_details_component__WEBPACK_IMPORTED_MODULE_58__ = __webpack_require__(/*! ./views/settings/timing-details/timing-details.component */ 6344);
/* harmony import */ var _desktop_views_reports_reports_component__WEBPACK_IMPORTED_MODULE_59__ = __webpack_require__(/*! ./desktop/views/reports/reports.component */ 6299);
/* harmony import */ var _desktop_reports_customer_order_customer_order_component__WEBPACK_IMPORTED_MODULE_60__ = __webpack_require__(/*! ./desktop/reports/customer-order/customer-order.component */ 202);
/* harmony import */ var _desktop_reports_sales_reports_sales_reports_component__WEBPACK_IMPORTED_MODULE_61__ = __webpack_require__(/*! ./desktop/reports/sales-reports/sales-reports.component */ 2061);
/* harmony import */ var _desktop_reports_product_reports_product_reports_component__WEBPACK_IMPORTED_MODULE_62__ = __webpack_require__(/*! ./desktop/reports/product-reports/product-reports.component */ 1225);
/* harmony import */ var _desktop_reports_customer_reports_customer_reports_component__WEBPACK_IMPORTED_MODULE_63__ = __webpack_require__(/*! ./desktop/reports/customer-reports/customer-reports.component */ 4649);
/* harmony import */ var _desktop_reports_brand_reports_brand_reports_component__WEBPACK_IMPORTED_MODULE_64__ = __webpack_require__(/*! ./desktop/reports/brand-reports/brand-reports.component */ 5085);
/* harmony import */ var _desktop_reports_trans_reports_trans_reports_component__WEBPACK_IMPORTED_MODULE_65__ = __webpack_require__(/*! ./desktop/reports/trans-reports/trans-reports.component */ 1823);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_66__ = __webpack_require__(/*! @angular/core */ 7716);






































































































class AppModule {
}
AppModule.ɵfac = function AppModule_Factory(t) { return new (t || AppModule)(); };
AppModule.ɵmod = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_66__["ɵɵdefineNgModule"]({ type: AppModule, bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent] });
AppModule.ɵinj = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_66__["ɵɵdefineInjector"]({ providers: [
        { provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_67__.HTTP_INTERCEPTORS, useClass: _auth_helpers_jwt_interceptor__WEBPACK_IMPORTED_MODULE_32__.JwtInterceptor, multi: true },
        { provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_67__.HTTP_INTERCEPTORS, useClass: _auth_helpers_error_interceptor__WEBPACK_IMPORTED_MODULE_33__.ErrorInterceptor, multi: true }
    ], imports: [[
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_68__.BrowserModule,
            _app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule,
            _ng_select_ng_select__WEBPACK_IMPORTED_MODULE_69__.NgSelectModule,
            _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_70__.BrowserAnimationsModule,
            ngx_daterangepicker_material__WEBPACK_IMPORTED_MODULE_71__.NgxDaterangepickerMd.forRoot(),
            _angular_forms__WEBPACK_IMPORTED_MODULE_72__.ReactiveFormsModule,
            _angular_common_http__WEBPACK_IMPORTED_MODULE_67__.HttpClientModule,
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_34__.SharedModule
        ]] });
(function () { (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_66__["ɵɵsetNgModuleScope"](AppModule, { declarations: [_app_component__WEBPACK_IMPORTED_MODULE_1__.AppComponent, _auth_login_login_component__WEBPACK_IMPORTED_MODULE_2__.LoginComponent, _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_3__.ForgetpasswordComponent, _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_4__.PhoneotpComponent, _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_5__.DashboardComponent, _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_6__.OrdersComponent, _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_7__.ReturnOrdersComponent, _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_8__.RefundComponent, _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__.CustomersComponent, _views_products_products_component__WEBPACK_IMPORTED_MODULE_10__.ProductsComponent, _components_topnav_topnav_component__WEBPACK_IMPORTED_MODULE_29__.TopnavComponent, _components_sidenavbar_sidenavbar_component__WEBPACK_IMPORTED_MODULE_28__.SidenavbarComponent, _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_11__.AddProductsComponent, _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_12__.ProductsCsvComponent, _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_13__.CategoriesComponent, _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_14__.AddCategoryComponent, _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_15__.SubCategoriesComponent, _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_16__.AddSubComponent, _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_17__.BrandsComponent, _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_18__.AddBrandComponent, _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_19__.OffersComponent, _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_20__.AddOffersComponent, _views_users_users_component__WEBPACK_IMPORTED_MODULE_21__.UsersComponent, _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_22__.AddUsersComponent, _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_23__.PaymentHistoryComponent, _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_25__.PaymentRequestsComponent, _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_24__.WalletHistoryComponent, _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_26__.AddWalletComponent, _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_27__.FinanceStatsComponent, _views_sub_categories_sub_categories_component__WEBPACK_IMPORTED_MODULE_15__.SubCategoriesComponent,
        _views_add_sub_add_sub_component__WEBPACK_IMPORTED_MODULE_16__.AddSubComponent,
        _views_brands_brands_component__WEBPACK_IMPORTED_MODULE_17__.BrandsComponent,
        _views_add_brand_add_brand_component__WEBPACK_IMPORTED_MODULE_18__.AddBrandComponent,
        _views_offers_offers_component__WEBPACK_IMPORTED_MODULE_19__.OffersComponent,
        _views_add_offers_add_offers_component__WEBPACK_IMPORTED_MODULE_20__.AddOffersComponent,
        _views_users_users_component__WEBPACK_IMPORTED_MODULE_21__.UsersComponent,
        _views_add_users_add_users_component__WEBPACK_IMPORTED_MODULE_22__.AddUsersComponent,
        _views_payment_history_payment_history_component__WEBPACK_IMPORTED_MODULE_23__.PaymentHistoryComponent,
        _views_wallet_history_wallet_history_component__WEBPACK_IMPORTED_MODULE_24__.WalletHistoryComponent,
        _views_payment_requests_payment_requests_component__WEBPACK_IMPORTED_MODULE_25__.PaymentRequestsComponent,
        _views_add_wallet_add_wallet_component__WEBPACK_IMPORTED_MODULE_26__.AddWalletComponent,
        _views_finance_stats_finance_stats_component__WEBPACK_IMPORTED_MODULE_27__.FinanceStatsComponent,
        _components_topnav_topnav_component__WEBPACK_IMPORTED_MODULE_29__.TopnavComponent,
        _auth_login_login_component__WEBPACK_IMPORTED_MODULE_2__.LoginComponent,
        _auth_forgetpassword_forgetpassword_component__WEBPACK_IMPORTED_MODULE_3__.ForgetpasswordComponent,
        _auth_phoneotp_phoneotp_component__WEBPACK_IMPORTED_MODULE_4__.PhoneotpComponent,
        _views_dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_5__.DashboardComponent,
        _components_sidenavbar_sidenavbar_component__WEBPACK_IMPORTED_MODULE_28__.SidenavbarComponent,
        _views_orders_orders_component__WEBPACK_IMPORTED_MODULE_6__.OrdersComponent,
        _views_return_orders_return_orders_component__WEBPACK_IMPORTED_MODULE_7__.ReturnOrdersComponent,
        _views_refund_refund_component__WEBPACK_IMPORTED_MODULE_8__.RefundComponent,
        _views_customers_customers_component__WEBPACK_IMPORTED_MODULE_9__.CustomersComponent,
        _views_products_products_component__WEBPACK_IMPORTED_MODULE_10__.ProductsComponent,
        _views_add_products_add_products_component__WEBPACK_IMPORTED_MODULE_11__.AddProductsComponent,
        _views_products_csv_products_csv_component__WEBPACK_IMPORTED_MODULE_12__.ProductsCsvComponent,
        _views_categories_categories_component__WEBPACK_IMPORTED_MODULE_13__.CategoriesComponent,
        _views_add_category_add_category_component__WEBPACK_IMPORTED_MODULE_14__.AddCategoryComponent,
        _layouts_main_layout_main_layout_component__WEBPACK_IMPORTED_MODULE_30__.MainLayoutComponent,
        _layouts_auth_layout_auth_layout_component__WEBPACK_IMPORTED_MODULE_31__.AuthLayoutComponent,
        _views_product_group_product_groups_component__WEBPACK_IMPORTED_MODULE_35__.ProductGroupsComponent,
        _views_add_product_group_add_prodouct_group_component__WEBPACK_IMPORTED_MODULE_36__.AddProductGroupComponent,
        _views_settings_settings_component__WEBPACK_IMPORTED_MODULE_37__.SettingsComponent,
        _views_settings_quantity_measures_quantity_measures_component__WEBPACK_IMPORTED_MODULE_38__.QuantityMeasuresComponent,
        _views_settings_setting_default_setting_default_component__WEBPACK_IMPORTED_MODULE_39__.SettingDefaultComponent,
        _views_settings_settings_nav_settings_nav_component__WEBPACK_IMPORTED_MODULE_40__.SettingsNavComponent,
        _views_settings_taxes_taxes_component__WEBPACK_IMPORTED_MODULE_41__.TaxesComponent,
        _views_settings_delivery_charges_delivery_charges_component__WEBPACK_IMPORTED_MODULE_42__.DeliveryChargesComponent,
        _views_order_details_order_details_component__WEBPACK_IMPORTED_MODULE_43__.OrderDetailsComponent,
        _views_manage_shared_manage_shared_component__WEBPACK_IMPORTED_MODULE_44__.ManageSharedComponent,
        _views_manage_home_banner_manage_home_banner_component__WEBPACK_IMPORTED_MODULE_45__.ManageHomeBannerComponent,
        _views_manage_featured_list_manage_featured_list_component__WEBPACK_IMPORTED_MODULE_46__.ManageFeaturedListComponent,
        _views_manage_top_brands_manage_top_brands_component__WEBPACK_IMPORTED_MODULE_47__.ManageTopBrandsComponent,
        _views_manage_mobile_manage_mobile_component__WEBPACK_IMPORTED_MODULE_48__.ManageMobileComponent,
        _views_slider_banners_slider_banners_component__WEBPACK_IMPORTED_MODULE_49__.SliderBannersComponent,
        _views_add_slider_banner_add_slider_banner_component__WEBPACK_IMPORTED_MODULE_50__.AddSliderBannerComponent,
        _views_mobile_custom_offer_mobile_custom_offer_component__WEBPACK_IMPORTED_MODULE_51__.MobileCustomOfferComponent,
        _views_manage_desktop_manage_desktop_component__WEBPACK_IMPORTED_MODULE_52__.ManageDesktopComponent,
        _views_four_banners_four_banners_component__WEBPACK_IMPORTED_MODULE_53__.FourBannersComponent,
        _views_add_fourbanners_add_fourbanners_component__WEBPACK_IMPORTED_MODULE_54__.AddFourbannersComponent,
        _views_offer_lists_offer_lists_component__WEBPACK_IMPORTED_MODULE_55__.OfferListsComponent,
        _views_add_offer_list_add_offer_list_component__WEBPACK_IMPORTED_MODULE_56__.AddOfferListComponent,
        _views_settings_delivery_timings_delivery_timings_component__WEBPACK_IMPORTED_MODULE_57__.DeliveryTimingsComponent,
        _views_settings_timing_details_timing_details_component__WEBPACK_IMPORTED_MODULE_58__.TimingDetailsComponent,
        _desktop_views_reports_reports_component__WEBPACK_IMPORTED_MODULE_59__.ReportsComponent,
        _desktop_reports_customer_order_customer_order_component__WEBPACK_IMPORTED_MODULE_60__.CustomerOrderComponent,
        _desktop_reports_sales_reports_sales_reports_component__WEBPACK_IMPORTED_MODULE_61__.SalesReportsComponent,
        _desktop_reports_product_reports_product_reports_component__WEBPACK_IMPORTED_MODULE_62__.ProductReportsComponent,
        _desktop_reports_customer_reports_customer_reports_component__WEBPACK_IMPORTED_MODULE_63__.CustomerReportsComponent,
        _desktop_reports_brand_reports_brand_reports_component__WEBPACK_IMPORTED_MODULE_64__.BrandReportsComponent,
        _desktop_reports_trans_reports_trans_reports_component__WEBPACK_IMPORTED_MODULE_65__.TransReportsComponent], imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_68__.BrowserModule,
        _app_routing_module__WEBPACK_IMPORTED_MODULE_0__.AppRoutingModule,
        _ng_select_ng_select__WEBPACK_IMPORTED_MODULE_69__.NgSelectModule,
        _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_70__.BrowserAnimationsModule, ngx_daterangepicker_material__WEBPACK_IMPORTED_MODULE_71__.NgxDaterangepickerMd, _angular_forms__WEBPACK_IMPORTED_MODULE_72__.ReactiveFormsModule,
        _angular_common_http__WEBPACK_IMPORTED_MODULE_67__.HttpClientModule,
        _shared_shared_module__WEBPACK_IMPORTED_MODULE_34__.SharedModule] }); })();


/***/ }),

/***/ 761:
/*!****************************************************!*\
  !*** ./src/app/auth/_helpers/error.interceptor.ts ***!
  \****************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ErrorInterceptor": () => (/* binding */ ErrorInterceptor)
/* harmony export */ });
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ 5917);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ 5304);
/* harmony import */ var src_app_models_common__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/app/models/common */ 1987);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _services_authentication_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../_services/authentication.service */ 7893);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ 9895);
/* harmony import */ var src_app_shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/shared/services/error-interceptor.service */ 5731);







class ErrorInterceptor {
    constructor(authenticationService, _router, errorIntrcptr) {
        this.authenticationService = authenticationService;
        this._router = _router;
        this.errorIntrcptr = errorIntrcptr;
    }
    intercept(request, next) {
        return next.handle(request).pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.catchError)(this.handleError()));
    }
    handleError(operation = 'operation', result) {
        return (error) => {
            if (error.status === 401) {
                this.authenticationService.logout();
                this._router.navigate(['/auth/login']);
                this.errorIntrcptr.httpErrorOccurred.next({ Message: "Please login to continue..", Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.ValidationError });
            }
            else if (error.status == 400) {
                let msg = "The request is Invalid";
                if (error.error != null
                    && error.error.message != null
                    && error.error.message.trim() != "") {
                    msg = error.error.message;
                }
                else if (error.error.error_description != null) {
                    msg = error.error.error_description;
                }
                this.errorIntrcptr.httpErrorOccurred.next({ Message: msg, Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Failure });
            }
            else if (error.status == 500) {
                this.errorIntrcptr.httpErrorOccurred.next({ Message: "Error occurred in the server", Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Error });
            }
            else if (error.status == 0) {
                this.errorIntrcptr.httpErrorOccurred.next({ Message: "Unable to connect the server", Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Error });
            }
            else {
                this.errorIntrcptr.httpErrorOccurred.next({ Message: "Unknown Error", Result: src_app_models_common__WEBPACK_IMPORTED_MODULE_0__.Result.Error });
            }
            console.log(`${operation} failed: ${error.message}`);
            return (0,rxjs__WEBPACK_IMPORTED_MODULE_4__.of)(result);
        };
    }
}
ErrorInterceptor.ɵfac = function ErrorInterceptor_Factory(t) { return new (t || ErrorInterceptor)(_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_1__.AuthenticationService), _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵinject"](_angular_router__WEBPACK_IMPORTED_MODULE_6__.Router), _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵinject"](src_app_shared_services_error_interceptor_service__WEBPACK_IMPORTED_MODULE_2__.ErrorInterceptorService)); };
ErrorInterceptor.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdefineInjectable"]({ token: ErrorInterceptor, factory: ErrorInterceptor.ɵfac });


/***/ }),

/***/ 4778:
/*!**************************************************!*\
  !*** ./src/app/auth/_helpers/jwt.interceptor.ts ***!
  \**************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "JwtInterceptor": () => (/* binding */ JwtInterceptor)
/* harmony export */ });
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _services_authentication_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../_services/authentication.service */ 7893);



class JwtInterceptor {
    constructor(authenticationService) {
        this.authenticationService = authenticationService;
    }
    intercept(request, next) {
        if (request.url.indexOf("https://atlas.microsoft.com") > -1) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.azureAuthorization}`
                }
            });
        }
        else if (request.url.indexOf("token") < 0) {
            let currentUser = this.authenticationService.currentUserValue;
            if (currentUser && currentUser.access_token) {
                request = request.clone({
                    setHeaders: {
                        Authorization: `Bearer ${currentUser.access_token}`
                    }
                });
            }
        }
        else { // ${currentUser.token}`,
            request = request.clone({
                setHeaders: {
                    "Content-Type": "application/x-www-form-urlencoded;charset=utf-8",
                    // 'Access-Control-Allow-Origin': '*',
                    //"Accept": "*/*"
                }
            });
        }
        return next.handle(request);
    }
}
JwtInterceptor.ɵfac = function JwtInterceptor_Factory(t) { return new (t || JwtInterceptor)(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_1__.AuthenticationService)); };
JwtInterceptor.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_2__["ɵɵdefineInjectable"]({ token: JwtInterceptor, factory: JwtInterceptor.ɵfac });


/***/ }),

/***/ 9757:
/*!*********************************************!*\
  !*** ./src/app/auth/_helpers/role.guard.ts ***!
  \*********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "RoleGuardService": () => (/* binding */ RoleGuardService)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _services_authentication_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../_services/authentication.service */ 7893);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ 9895);



class RoleGuardService {
    constructor(_authService, _router) {
        this._authService = _authService;
        this._router = _router;
    }
    canActivate(next, state) {
        var _a;
        const currentUser = this._authService.currentUserValue;
        let res = false;
        if (currentUser != null) {
            let userRoles = ((_a = currentUser.roles) !== null && _a !== void 0 ? _a : "").split(",");
            res = next.data.roles && next.data.roles.some((ai) => userRoles.includes(ai));
        }
        if (res == false) {
            this._router.navigate(['/auth/login']);
        }
        return res;
    }
}
RoleGuardService.ɵfac = function RoleGuardService_Factory(t) { return new (t || RoleGuardService)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_0__.AuthenticationService), _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵinject"](_angular_router__WEBPACK_IMPORTED_MODULE_2__.Router)); };
RoleGuardService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineInjectable"]({ token: RoleGuardService, factory: RoleGuardService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 4621:
/*!**************************************!*\
  !*** ./src/app/auth/_models/role.ts ***!
  \**************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "Role": () => (/* binding */ Role)
/* harmony export */ });
var Role;
(function (Role) {
    Role["Admin"] = "Admin";
    Role["User"] = "User";
})(Role || (Role = {}));


/***/ }),

/***/ 7893:
/*!**********************************************************!*\
  !*** ./src/app/auth/_services/authentication.service.ts ***!
  \**********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AuthenticationService": () => (/* binding */ AuthenticationService)
/* harmony export */ });
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ 1841);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ 6215);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ 8002);
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ 7716);






class AuthenticationService {
    constructor(http) {
        var _a;
        this.http = http;
        this.currentUserSubject = new rxjs__WEBPACK_IMPORTED_MODULE_1__.BehaviorSubject(JSON.parse((_a = localStorage.getItem('currentUser')) !== null && _a !== void 0 ? _a : "{}"));
        this.currentUser = this.currentUserSubject.asObservable();
    }
    get currentUserValue() {
        return this.currentUserSubject.value;
    }
    login(username, password) {
        const myheader = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded');
        let body = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpParams();
        body = body.set('UserName', username);
        body = body.set('Password', password);
        body = body.set('grant_type', "password");
        return this.http.post(`${src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.appAuthUrl}`, body, {
            headers: myheader
        }).pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.map)(user => {
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
        }));
    }
    signup(fullName, phoneNumber, username, password, confirm) {
        return this.http.post(`${src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.apiUrl}auth/register`, {
            "Aadhar": "", "Address": "",
            "FullName": fullName, "PhoneNumber": phoneNumber,
            "Email": username, "Password": password, "ConfirmPassword": confirm
        })
            .pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_3__.map)(user => {
            localStorage.setItem('currentUser', JSON.stringify(user));
            this.currentUserSubject.next(user);
            return user;
        }));
    }
    logout() {
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
    }
}
AuthenticationService.ɵfac = function AuthenticationService_Factory(t) { return new (t || AuthenticationService)(_angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵinject"](_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient)); };
AuthenticationService.ɵprov = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_4__["ɵɵdefineInjectable"]({ token: AuthenticationService, factory: AuthenticationService.ɵfac, providedIn: 'root' });


/***/ }),

/***/ 7412:
/*!*****************************************************************!*\
  !*** ./src/app/auth/forgetpassword/forgetpassword.component.ts ***!
  \*****************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ForgetpasswordComponent": () => (/* binding */ ForgetpasswordComponent)
/* harmony export */ });
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ 3679);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ 9895);




class ForgetpasswordComponent {
    constructor() {
        this.assetUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.assetsUrl;
    }
    ngOnInit() {
    }
}
ForgetpasswordComponent.ɵfac = function ForgetpasswordComponent_Factory(t) { return new (t || ForgetpasswordComponent)(); };
ForgetpasswordComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: ForgetpasswordComponent, selectors: [["app-forgetpassword"]], decls: 16, vars: 1, consts: [["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-1@m", "uk-text-center"], [1, "uk-card", "login-form-grid", "uk-align-center", "uk-margin-large", "uk-card-body"], ["alt", "", 1, "login-logo"], [1, "uk-form-stacked", "uk-margin-medium-top"], [1, "uk-margin-remove"], ["for", "form-stacked-text", 1, "uk-form-label", "uk-align-left", "login-label"], [1, "uk-form-controls"], ["id", "form-stacked-text", "type", "email", "placeholder", "Enter your phone number", "name", "email", "ngModel", "", "email", "true", 1, "uk-input", "login-input"], ["routerLink", "/enter-otp", 1, "uk-button", "uk-width-1-1", "login-btn", "uk-margin-small"], [1, "forget-password"], ["routerLink", "/login", 1, "uk-button-text"]], template: function ForgetpasswordComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](3, "img", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "form", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](6, "label", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](7, "Phone Number");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](9, "input", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "button", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](11, "Send OTP");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](12, "p", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](13, "If you know your password : ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "a", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](15, "Sign In");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵattribute"]("src", ctx.assetUrl + "/icon.png", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsanitizeUrl"]);
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgForm, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgModel, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.EmailValidator, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterLink, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterLinkWithHref], styles: ["body[_ngcontent-%COMP%] {\r\n  background-color: #dee1ec;\r\n  font-family: 'Poppins', sans-serif;\r\n}\r\n\r\n\r\n.login-img[_ngcontent-%COMP%] {\r\n  object-fit: cover;\r\n  min-height: 100vh !important;\r\n  width: 100%;\r\n}\r\n\r\n\r\n.login-grid[_ngcontent-%COMP%] {\r\n  background-color: #dee1ec;\r\n  height: 100vh;\r\n}\r\n\r\n\r\n.login-form-grid[_ngcontent-%COMP%] {\r\n  background-color: white;\r\n  border-radius: 8px;\r\n  top:20%;\r\n  width: 60%;\r\n  overflow:hidden;\r\n}\r\n\r\n\r\n.login-logo[_ngcontent-%COMP%] {\r\n  width: 50px;\r\n}\r\n\r\n\r\n.login-label[_ngcontent-%COMP%] {\r\n  margin-bottom:8px;\r\n  font-size:8pt;\r\n  font-weight: 600;\r\n  text-transform: uppercase;\r\n  display:inline-block;\r\n  letter-spacing: 1px;\r\n}\r\n\r\n\r\n.login-input[_ngcontent-%COMP%] {\r\n  font-size: 10pt;\r\n  color: black;\r\n  border: 1px solid #dee1ec;\r\n  background-color: #dee1ec;\r\n  border-radius: 4px;\r\n}\r\n\r\n\r\n.login-input[_ngcontent-%COMP%]::placeholder {\r\n  color: #00000070;\r\n  font-size: 9pt;\r\n  font-weight: 600;\r\n}\r\n\r\n\r\n.login-input-icon[_ngcontent-%COMP%] {\r\n  color: black;\r\n  cursor: pointer;\r\n  font-size: 16pt;\r\n}\r\n\r\n\r\n.login-btn[_ngcontent-%COMP%] {\r\n  background-color: #10316b;\r\n  color: white;\r\n  border-radius: 8px;\r\n  text-transform: none;\r\n  font-size: 10pt;\r\n  padding: 4px 20px;\r\n}\r\n\r\n\r\n.login-btn[_ngcontent-%COMP%]:hover {\r\n  background-color: #0b8457 ;\r\n}\r\n\r\n\r\n.forget-password[_ngcontent-%COMP%] {\r\n  font-size: 9pt;\r\n  color: grey;\r\n  margin-top: 6px;\r\n  font-weight: 400;\r\n}\r\n\r\n\r\n.forget-password[_ngcontent-%COMP%] > a[_ngcontent-%COMP%] {\r\n  color: #10316b;\r\n  text-decoration: none;\r\n  font-weight: 500;\r\n  font-weight: 10pt;\r\n}\r\n\r\n\r\n.forget-password[_ngcontent-%COMP%] > a[_ngcontent-%COMP%]:hover {\r\n  color: #0b8457;\r\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UseUJBQXlCO0VBQ3pCLGtDQUFrQztBQUNwQzs7O0FBR0E7RUFDRSxpQkFBaUI7RUFDakIsNEJBQTRCO0VBQzVCLFdBQVc7QUFDYjs7O0FBRUE7RUFDRSx5QkFBeUI7RUFDekIsYUFBYTtBQUNmOzs7QUFFQTtFQUNFLHVCQUF1QjtFQUN2QixrQkFBa0I7RUFDbEIsT0FBTztFQUNQLFVBQVU7RUFDVixlQUFlO0FBQ2pCOzs7QUFFQTtFQUNFLFdBQVc7QUFDYjs7O0FBRUE7RUFDRSxpQkFBaUI7RUFDakIsYUFBYTtFQUNiLGdCQUFnQjtFQUNoQix5QkFBeUI7RUFDekIsb0JBQW9CO0VBQ3BCLG1CQUFtQjtBQUNyQjs7O0FBRUE7RUFDRSxlQUFlO0VBQ2YsWUFBWTtFQUNaLHlCQUF5QjtFQUN6Qix5QkFBeUI7RUFDekIsa0JBQWtCO0FBQ3BCOzs7QUFFQTtFQUNFLGdCQUFnQjtFQUNoQixjQUFjO0VBQ2QsZ0JBQWdCO0FBQ2xCOzs7QUFFQTtFQUNFLFlBQVk7RUFDWixlQUFlO0VBQ2YsZUFBZTtBQUNqQjs7O0FBRUE7RUFDRSx5QkFBeUI7RUFDekIsWUFBWTtFQUNaLGtCQUFrQjtFQUNsQixvQkFBb0I7RUFDcEIsZUFBZTtFQUNmLGlCQUFpQjtBQUNuQjs7O0FBRUE7RUFDRSwwQkFBMEI7QUFDNUI7OztBQUVBO0VBQ0UsY0FBYztFQUNkLFdBQVc7RUFDWCxlQUFlO0VBQ2YsZ0JBQWdCO0FBQ2xCOzs7QUFFQTtFQUNFLGNBQWM7RUFDZCxxQkFBcUI7RUFDckIsZ0JBQWdCO0VBQ2hCLGlCQUFpQjtBQUNuQjs7O0FBRUE7RUFDRSxjQUFjO0FBQ2hCIiwiZmlsZSI6ImZvcmdldHBhc3N3b3JkLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiYm9keSB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogI2RlZTFlYztcclxuICBmb250LWZhbWlseTogJ1BvcHBpbnMnLCBzYW5zLXNlcmlmO1xyXG59XHJcblxyXG5cclxuLmxvZ2luLWltZyB7XHJcbiAgb2JqZWN0LWZpdDogY292ZXI7XHJcbiAgbWluLWhlaWdodDogMTAwdmggIWltcG9ydGFudDtcclxuICB3aWR0aDogMTAwJTtcclxufVxyXG5cclxuLmxvZ2luLWdyaWQge1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICNkZWUxZWM7XHJcbiAgaGVpZ2h0OiAxMDB2aDtcclxufVxyXG5cclxuLmxvZ2luLWZvcm0tZ3JpZCB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7XHJcbiAgYm9yZGVyLXJhZGl1czogOHB4O1xyXG4gIHRvcDoyMCU7XHJcbiAgd2lkdGg6IDYwJTtcclxuICBvdmVyZmxvdzpoaWRkZW47XHJcbn1cclxuXHJcbi5sb2dpbi1sb2dvIHtcclxuICB3aWR0aDogNTBweDtcclxufVxyXG5cclxuLmxvZ2luLWxhYmVsIHtcclxuICBtYXJnaW4tYm90dG9tOjhweDtcclxuICBmb250LXNpemU6OHB0O1xyXG4gIGZvbnQtd2VpZ2h0OiA2MDA7XHJcbiAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcclxuICBkaXNwbGF5OmlubGluZS1ibG9jaztcclxuICBsZXR0ZXItc3BhY2luZzogMXB4O1xyXG59XHJcblxyXG4ubG9naW4taW5wdXQge1xyXG4gIGZvbnQtc2l6ZTogMTBwdDtcclxuICBjb2xvcjogYmxhY2s7XHJcbiAgYm9yZGVyOiAxcHggc29saWQgI2RlZTFlYztcclxuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZGVlMWVjO1xyXG4gIGJvcmRlci1yYWRpdXM6IDRweDtcclxufVxyXG5cclxuLmxvZ2luLWlucHV0OjpwbGFjZWhvbGRlciB7XHJcbiAgY29sb3I6ICMwMDAwMDA3MDtcclxuICBmb250LXNpemU6IDlwdDtcclxuICBmb250LXdlaWdodDogNjAwO1xyXG59XHJcblxyXG4ubG9naW4taW5wdXQtaWNvbiB7XHJcbiAgY29sb3I6IGJsYWNrO1xyXG4gIGN1cnNvcjogcG9pbnRlcjtcclxuICBmb250LXNpemU6IDE2cHQ7XHJcbn1cclxuXHJcbi5sb2dpbi1idG4ge1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICMxMDMxNmI7XHJcbiAgY29sb3I6IHdoaXRlO1xyXG4gIGJvcmRlci1yYWRpdXM6IDhweDtcclxuICB0ZXh0LXRyYW5zZm9ybTogbm9uZTtcclxuICBmb250LXNpemU6IDEwcHQ7XHJcbiAgcGFkZGluZzogNHB4IDIwcHg7XHJcbn1cclxuXHJcbi5sb2dpbi1idG46aG92ZXIge1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICMwYjg0NTcgO1xyXG59XHJcblxyXG4uZm9yZ2V0LXBhc3N3b3JkIHtcclxuICBmb250LXNpemU6IDlwdDtcclxuICBjb2xvcjogZ3JleTtcclxuICBtYXJnaW4tdG9wOiA2cHg7XHJcbiAgZm9udC13ZWlnaHQ6IDQwMDtcclxufVxyXG5cclxuLmZvcmdldC1wYXNzd29yZD5hIHtcclxuICBjb2xvcjogIzEwMzE2YjtcclxuICB0ZXh0LWRlY29yYXRpb246IG5vbmU7XHJcbiAgZm9udC13ZWlnaHQ6IDUwMDtcclxuICBmb250LXdlaWdodDogMTBwdDtcclxufVxyXG5cclxuLmZvcmdldC1wYXNzd29yZD5hOmhvdmVyIHtcclxuICBjb2xvcjogIzBiODQ1NztcclxufVxyXG4iXX0= */"] });


/***/ }),

/***/ 8146:
/*!***********************************************!*\
  !*** ./src/app/auth/login/login.component.ts ***!
  \***********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LoginComponent": () => (/* binding */ LoginComponent)
/* harmony export */ });
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ 3679);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ 8049);
/* harmony import */ var src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/app/shared/base.component */ 7947);
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _services_authentication_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../_services/authentication.service */ 7893);
/* harmony import */ var ngx_spinner__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-spinner */ 9866);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/router */ 9895);









class LoginComponent extends src_app_shared_base_component__WEBPACK_IMPORTED_MODULE_0__.BaseComponent {
    constructor(injector, authenticationService) {
        super(injector);
        this.injector = injector;
        this.authenticationService = authenticationService;
        this.submitted = true;
        this.assetUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_1__.environment.assetsUrl;
        this.showPassword = false;
        this.formInstance = this.fb.group({
            UserName: ['', [_angular_forms__WEBPACK_IMPORTED_MODULE_3__.Validators.required]],
            Password: ['', _angular_forms__WEBPACK_IMPORTED_MODULE_3__.Validators.required]
        });
    }
    ngOnInit() {
    }
    get email() {
        return this.formInstance.get('UserName');
    }
    get password() {
        return this.formInstance.get('Password');
    }
    visibility() {
        this.showPassword = !this.showPassword;
    }
    submitForm() {
        var _a, _b;
        this.router.navigate(['/admin']);
        this.submitted = true;
        if (this.formInstance.invalid) {
            return;
        }
        this.showFullSpinner();
        this.authenticationService.login((_a = this.email) === null || _a === void 0 ? void 0 : _a.value, (_b = this.password) === null || _b === void 0 ? void 0 : _b.value)
            .pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.first)())
            .subscribe(() => {
            this.hideFullSpinner();
            this.router.navigate(["/"]);
        }, (error) => {
            setTimeout(() => {
                this.hideFullSpinner();
                this.spinner.hide();
            }, 500);
        });
    }
}
LoginComponent.ɵfac = function LoginComponent_Factory(t) { return new (t || LoginComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdirectiveInject"](_angular_core__WEBPACK_IMPORTED_MODULE_5__.Injector), _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdirectiveInject"](_services_authentication_service__WEBPACK_IMPORTED_MODULE_2__.AuthenticationService)); };
LoginComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵdefineComponent"]({ type: LoginComponent, selectors: [["app-login"]], features: [_angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵInheritDefinitionFeature"]], decls: 25, vars: 4, consts: [[1, "uk-card", "login-grid", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-1@m", "uk-text-center"], [1, "uk-card", "login-form-grid", "uk-align-center", "uk-margin-large", "uk-card-body"], [3, "name"], ["alt", "", 1, "login-logo"], [1, "uk-form-stacked", "uk-margin-medium-top", 3, "formGroup", "ngSubmit"], [1, "uk-margin-small"], ["for", "form-stacked-text", 1, "uk-form-label", "uk-align-left", "login-label"], [1, "uk-form-controls", "form-stacked-text"], ["formControlName", "UserName", "placeholder", "mial@example.com", 1, "uk-input", "login-input"], [1, "uk-inline", "uk-width-1-1"], [1, "uk-form-icon", "uk-form-icon-flip", "material-icons", "login-input-icon", 3, "click"], ["formControlName", "Password", "placeholder", "*******", "autocomplete", "off", 1, "uk-input", "login-input", "form-stacked-text"], ["type", "submit", 1, "uk-button", "uk-width-1-1", "login-btn", "uk-margin"], [1, "forget-password"], ["routerLink", "/forgetpassword", 1, "uk-button-text"]], template: function LoginComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](2, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](3, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](4, "ngx-spinner", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](5, "img", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](6, "form", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵlistener"]("ngSubmit", function LoginComponent_Template_form_ngSubmit_6_listener() { return ctx.formInstance.valid && ctx.submitForm(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](7, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](8, "label", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](9, "Email");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](10, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](11, "input", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](12, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](13, "label", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](14, "Password");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](15, "div", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](16, "span", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵlistener"]("click", function LoginComponent_Template_span_click_16_listener() { return ctx.visibility(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](17, "visibility");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelement"](18, "input", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](19, "button", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](20, "Sign in");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](21, "p", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](22, "Don't have an account : ");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementStart"](23, "a", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵtext"](24, "Forget password?");
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](4);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵproperty"]("name", ctx.loadSpinner);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵattribute"]("src", ctx.assetUrl + "/icon.png", _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵsanitizeUrl"]);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵproperty"]("formGroup", ctx.formInstance);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵadvance"](12);
        _angular_core__WEBPACK_IMPORTED_MODULE_5__["ɵɵattribute"]("type", ctx.showPassword ? "text" : "password");
    } }, directives: [ngx_spinner__WEBPACK_IMPORTED_MODULE_6__.NgxSpinnerComponent, _angular_forms__WEBPACK_IMPORTED_MODULE_3__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormGroupDirective, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_3__.FormControlName, _angular_router__WEBPACK_IMPORTED_MODULE_7__.RouterLinkWithHref], styles: ["body[_ngcontent-%COMP%] {\n  background-color: #dee1ec;\n  font-family: \"Poppins\", sans-serif;\n}\n\n.login-img[_ngcontent-%COMP%] {\n  object-fit: cover;\n  min-height: 100vh !important;\n  width: 100%;\n}\n\n.login-grid[_ngcontent-%COMP%] {\n  background-color: #dee1ec;\n  height: 100vh;\n}\n\n.login-form-grid[_ngcontent-%COMP%] {\n  background-color: white;\n  border-radius: 8px;\n  top: 20%;\n  width: 60%;\n  overflow: hidden;\n}\n\n.login-logo[_ngcontent-%COMP%] {\n  width: 50px;\n}\n\n.login-label[_ngcontent-%COMP%] {\n  margin-bottom: 8px;\n  font-size: 8pt;\n  font-weight: 600;\n  text-transform: uppercase;\n  display: inline-block;\n  letter-spacing: 1px;\n}\n\n.login-input[_ngcontent-%COMP%] {\n  font-size: 10pt;\n  color: black;\n  border: 1px solid #dee1ec;\n  background-color: #dee1ec;\n  border-radius: 4px;\n}\n\n.login-input[_ngcontent-%COMP%]::placeholder {\n  color: #00000070;\n  font-size: 9pt;\n  font-weight: 600;\n}\n\n.login-input-icon[_ngcontent-%COMP%] {\n  color: black;\n  cursor: pointer;\n  font-size: 16pt;\n}\n\n.login-btn[_ngcontent-%COMP%] {\n  background-color: #10316b;\n  color: white;\n  border-radius: 8px;\n  text-transform: none;\n  font-size: 10pt;\n  padding: 4px 20px;\n}\n\n.login-btn[_ngcontent-%COMP%]:hover {\n  background-color: #0b8457;\n}\n\n.forget-password[_ngcontent-%COMP%] {\n  font-size: 9pt;\n  color: grey;\n  margin-top: 6px;\n  font-weight: 400;\n}\n\n.forget-password[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: #10316b;\n  text-decoration: none;\n  font-weight: 500;\n  font-weight: 10pt;\n}\n\n.forget-password[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]:hover {\n  color: #0b8457;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImxvZ2luLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0UseUJBQUE7RUFDQSxrQ0FBQTtBQUNGOztBQUdBO0VBQ0UsaUJBQUE7RUFDQSw0QkFBQTtFQUNBLFdBQUE7QUFBRjs7QUFHQTtFQUNFLHlCQUFBO0VBQ0EsYUFBQTtBQUFGOztBQUdBO0VBQ0UsdUJBQUE7RUFDQSxrQkFBQTtFQUNBLFFBQUE7RUFDQSxVQUFBO0VBQ0EsZ0JBQUE7QUFBRjs7QUFHQTtFQUNFLFdBQUE7QUFBRjs7QUFHQTtFQUNFLGtCQUFBO0VBQ0EsY0FBQTtFQUNBLGdCQUFBO0VBQ0EseUJBQUE7RUFDQSxxQkFBQTtFQUNBLG1CQUFBO0FBQUY7O0FBR0E7RUFDRSxlQUFBO0VBQ0EsWUFBQTtFQUNBLHlCQUFBO0VBQ0EseUJBQUE7RUFDQSxrQkFBQTtBQUFGOztBQUdBO0VBQ0UsZ0JBQUE7RUFDQSxjQUFBO0VBQ0EsZ0JBQUE7QUFBRjs7QUFHQTtFQUNFLFlBQUE7RUFDQSxlQUFBO0VBQ0EsZUFBQTtBQUFGOztBQUdBO0VBQ0UseUJBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7RUFDQSxvQkFBQTtFQUNBLGVBQUE7RUFDQSxpQkFBQTtBQUFGOztBQUdBO0VBQ0UseUJBQUE7QUFBRjs7QUFHQTtFQUNFLGNBQUE7RUFDQSxXQUFBO0VBQ0EsZUFBQTtFQUNBLGdCQUFBO0FBQUY7O0FBR0E7RUFDRSxjQUFBO0VBQ0EscUJBQUE7RUFDQSxnQkFBQTtFQUNBLGlCQUFBO0FBQUY7O0FBR0E7RUFDRSxjQUFBO0FBQUYiLCJmaWxlIjoibG9naW4uY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyJib2R5IHtcclxuICBiYWNrZ3JvdW5kLWNvbG9yOiAjZGVlMWVjO1xyXG4gIGZvbnQtZmFtaWx5OiAnUG9wcGlucycsIHNhbnMtc2VyaWY7XHJcbn1cclxuXHJcblxyXG4ubG9naW4taW1nIHtcclxuICBvYmplY3QtZml0OiBjb3ZlcjtcclxuICBtaW4taGVpZ2h0OiAxMDB2aCAhaW1wb3J0YW50O1xyXG4gIHdpZHRoOiAxMDAlO1xyXG59XHJcblxyXG4ubG9naW4tZ3JpZCB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogI2RlZTFlYztcclxuICBoZWlnaHQ6IDEwMHZoO1xyXG59XHJcblxyXG4ubG9naW4tZm9ybS1ncmlkIHtcclxuICBiYWNrZ3JvdW5kLWNvbG9yOiB3aGl0ZTtcclxuICBib3JkZXItcmFkaXVzOiA4cHg7XHJcbiAgdG9wOjIwJTtcclxuICB3aWR0aDogNjAlO1xyXG4gIG92ZXJmbG93OmhpZGRlbjtcclxufVxyXG5cclxuLmxvZ2luLWxvZ28ge1xyXG4gIHdpZHRoOiA1MHB4O1xyXG59XHJcblxyXG4ubG9naW4tbGFiZWwge1xyXG4gIG1hcmdpbi1ib3R0b206OHB4O1xyXG4gIGZvbnQtc2l6ZTo4cHQ7XHJcbiAgZm9udC13ZWlnaHQ6IDYwMDtcclxuICB0ZXh0LXRyYW5zZm9ybTogdXBwZXJjYXNlO1xyXG4gIGRpc3BsYXk6aW5saW5lLWJsb2NrO1xyXG4gIGxldHRlci1zcGFjaW5nOiAxcHg7XHJcbn1cclxuXHJcbi5sb2dpbi1pbnB1dCB7XHJcbiAgZm9udC1zaXplOiAxMHB0O1xyXG4gIGNvbG9yOiBibGFjaztcclxuICBib3JkZXI6IDFweCBzb2xpZCAjZGVlMWVjO1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICNkZWUxZWM7XHJcbiAgYm9yZGVyLXJhZGl1czogNHB4O1xyXG59XHJcblxyXG4ubG9naW4taW5wdXQ6OnBsYWNlaG9sZGVyIHtcclxuICBjb2xvcjogIzAwMDAwMDcwO1xyXG4gIGZvbnQtc2l6ZTogOXB0O1xyXG4gIGZvbnQtd2VpZ2h0OiA2MDA7XHJcbn1cclxuXHJcbi5sb2dpbi1pbnB1dC1pY29uIHtcclxuICBjb2xvcjogYmxhY2s7XHJcbiAgY3Vyc29yOiBwb2ludGVyO1xyXG4gIGZvbnQtc2l6ZTogMTZwdDtcclxufVxyXG5cclxuLmxvZ2luLWJ0biB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogIzEwMzE2YjtcclxuICBjb2xvcjogd2hpdGU7XHJcbiAgYm9yZGVyLXJhZGl1czogOHB4O1xyXG4gIHRleHQtdHJhbnNmb3JtOiBub25lO1xyXG4gIGZvbnQtc2l6ZTogMTBwdDtcclxuICBwYWRkaW5nOiA0cHggMjBweDtcclxufVxyXG5cclxuLmxvZ2luLWJ0bjpob3ZlciB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogIzBiODQ1NyA7XHJcbn1cclxuXHJcbi5mb3JnZXQtcGFzc3dvcmQge1xyXG4gIGZvbnQtc2l6ZTogOXB0O1xyXG4gIGNvbG9yOiBncmV5O1xyXG4gIG1hcmdpbi10b3A6IDZweDtcclxuICBmb250LXdlaWdodDogNDAwO1xyXG59XHJcblxyXG4uZm9yZ2V0LXBhc3N3b3JkPmEge1xyXG4gIGNvbG9yOiAjMTAzMTZiO1xyXG4gIHRleHQtZGVjb3JhdGlvbjogbm9uZTtcclxuICBmb250LXdlaWdodDogNTAwO1xyXG4gIGZvbnQtd2VpZ2h0OiAxMHB0O1xyXG59XHJcblxyXG4uZm9yZ2V0LXBhc3N3b3JkPmE6aG92ZXIge1xyXG4gIGNvbG9yOiAjMGI4NDU3O1xyXG59XHJcbiJdfQ== */"] });


/***/ }),

/***/ 5180:
/*!*****************************************************!*\
  !*** ./src/app/auth/phoneotp/phoneotp.component.ts ***!
  \*****************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PhoneotpComponent": () => (/* binding */ PhoneotpComponent)
/* harmony export */ });
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ 3679);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ 9895);




class PhoneotpComponent {
    constructor() {
        this.assetsUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.assetsUrl;
    }
    ngOnInit() {
    }
}
PhoneotpComponent.ɵfac = function PhoneotpComponent_Factory(t) { return new (t || PhoneotpComponent)(); };
PhoneotpComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: PhoneotpComponent, selectors: [["app-phoneotp"]], decls: 18, vars: 2, consts: [["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-grid-match", "uk-child-width-1-2@m", "uk-grid-collapse", "uk-text-center"], [1, "uk-card", "uk-padding-remove", "uk-card-body"], ["alt", "", 1, "login-img"], [1, "uk-card", "login-grid", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-1@m", "uk-text-center"], [1, "uk-card", "login-form-grid", "uk-align-center", "uk-margin-large", "uk-card-body"], ["alt", "", 1, "login-logo"], [1, "uk-form-stacked", "uk-margin-medium-top"], [1, "uk-margin-remove"], [1, "uk-form-controls"], ["id", "form-stacked-text", "type", "email", "placeholder", "Enter OTP", "name", "email", "ngModel", "", "email", "true", 1, "uk-input", "login-input"], ["routerLink", "/forget_passwordComponents", "routerLinkActive", "active", 1, "uk-button", "uk-width-1-1", "login-btn", "uk-margin-small"], [1, "forget-password"]], template: function PhoneotpComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](3, "img", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](6, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](7, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](9, "img", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "form", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](11, "div", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](12, "div", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](13, "input", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "button", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](15, "Confirm & Continue");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](16, "p", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](17, "We will mail you new password");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵattribute"]("src", ctx.assetsUrl + "/login-1.jpg", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsanitizeUrl"]);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵattribute"]("src", ctx.assetsUrl + "/icon.png", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsanitizeUrl"]);
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_2__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgForm, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.DefaultValueAccessor, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgControlStatus, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.NgModel, _angular_forms__WEBPACK_IMPORTED_MODULE_2__.EmailValidator, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterLink, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterLinkActive], styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJwaG9uZW90cC5jb21wb25lbnQuc2NzcyJ9 */"] });


/***/ }),

/***/ 5536:
/*!***************************************************************!*\
  !*** ./src/app/components/sidenavbar/sidenavbar.component.ts ***!
  \***************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "SidenavbarComponent": () => (/* binding */ SidenavbarComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/environments/environment */ 2340);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ 8583);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ 9895);





const _c0 = function (a1) { return { "uk-width-1-1@s uk-width-1-1@m uk-margin-top": true, "is-closed": a1 }; };
class SidenavbarComponent {
    constructor() {
        this.assetUrl = src_environments_environment__WEBPACK_IMPORTED_MODULE_0__.environment.assetsUrl;
        this.open = false;
        this.openChange = new _angular_core__WEBPACK_IMPORTED_MODULE_1__.EventEmitter();
    }
    ngOnInit() {
    }
}
SidenavbarComponent.ɵfac = function SidenavbarComponent_Factory(t) { return new (t || SidenavbarComponent)(); };
SidenavbarComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: SidenavbarComponent, selectors: [["app-sidenavbar"]], inputs: { open: "open" }, outputs: { openChange: "openChange" }, decls: 181, vars: 4, consts: [[1, "uk-card", "sidenav-bar", "uk-card-body"], ["alt", "", 1, "sidenav-logo", "uk-align-center"], [3, "ngClass"], ["uk-nav", "", 1, "uk-nav-default", "sidenav-menu", "uk-nav-parent-icon"], [1, "uk-active"], ["routerLink", "/"], [1, "material-icons-two-tone"], [1, "menu-title"], [1, "uk-parent"], ["href", "#"], [1, "material-icons-two-tone", "chev-down"], [1, "uk-nav-sub"], [1, "sidenav-dropdown"], ["routerLink", "/orders"], ["routerLink", "/returns"], ["routerLink", "/customers"], ["routerLink", "/products"], ["routerLink", "/products/add"], ["routerLink", "/product-groups"], ["routerLink", "/categories"], ["routerLink", "/sub-categories"], ["routerLink", "/brands"], ["routerLink", "/manage-shared"], ["routerLink", "/manage-mobile"], ["routerLink", "/manage-desktop"], ["routerLink", "/offers"], ["routerLink", "/offer-lists"], ["routerLink", "/users"], ["routerLink", "/payment-history"], ["routerLink", "/wallet-history"], ["routerLink", "/payment-request"], ["routerLink", "/add-wallet"], ["routerLink", "/finance-stats"], ["routerLink", "/co-reports"], ["routerLink", "/sales-reports"], ["routerLink", "/product-reports"], ["routerLink", "/customer-reports"], ["routerLink", "/brand-reports"], ["routerLink", "/trans-reports"], ["routerLink", "/category-reports"], ["routerLink", "/sub-reports"], ["routerLink", "/redeem-reports"], ["routerLink", "/tax-reports"], ["routerLink", "/wallet-reports"], ["routerLink", "/rc-reports"], ["routerLink", "/rc-product-reports"], ["routerLink", "/p-lose"], ["routerLink", "/stats"], ["routerLink", "/settings"]], template: function SidenavbarComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelement"](1, "img", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "div", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](3, "ul", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "li", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "a", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](6, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](7, " home ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](9, "Home");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](11, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](12, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](13, " local_mall ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](15, " Orders ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](16, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](17, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](18, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](19, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](20, "a", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](21, "Orders");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](22, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](23, "a", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](24, "Return / Cancel");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](25, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](26, "a", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](27, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](28, " people ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](29, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](30, " Customers ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](31, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](32, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](33, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](34, " storefront ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](35, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](36, "Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](37, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](38, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](39, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](40, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](41, "a", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](42, "Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](43, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](44, "a", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](45, "Add Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](46, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](47, "a", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](48, "Product Groups");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](49, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](50, "a", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](51, "Categories");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](52, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](53, "a", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](54, "Sub-Categories");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](55, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](56, "a", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](57, "Brands");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](58, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](59, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](60, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](61, " menu ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](62, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](63, "Manage Apps");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](64, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](65, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](66, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](67, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](68, "a", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](69, "Shared");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](70, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](71, "a", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](72, "Mobile");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](73, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](74, "a", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](75, "Desktop");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](76, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](77, "a", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](78, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](79, " local_offer ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](80, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](81, "Offers");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](82, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](83, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](84, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](85, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](86, "a", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](87, "Offers Displays");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](88, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](89, "a", 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](90, "Offer Lists");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](91, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](92, "a", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](93, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](94, " folder_shared ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](95, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](96, "Users");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](97, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](98, "a");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](99, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](100, " account_balance ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](101, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](102, " Finance");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](103, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](104, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](105, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](106, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](107, "a", 28);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](108, "Payment History");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](109, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](110, "a", 29);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](111, "Wallet History");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](112, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](113, "a", 30);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](114, "Payment Request");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](115, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](116, "a", 31);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](117, "Add Wallet");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](118, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](119, "a", 32);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](120, "Stats");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](121, "li", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](122, "a");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](123, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](124, " insights ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](125, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](126, " Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](127, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](128, " navigate_next ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](129, "ul", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](130, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](131, "a", 33);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](132, "Customers Orders");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](133, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](134, "a", 34);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](135, "Sales Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](136, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](137, "a", 35);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](138, "Product Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](139, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](140, "a", 36);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](141, "Customer Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](142, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](143, "a", 37);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](144, "Brands Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](145, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](146, "a", 38);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](147, "Transaction Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](148, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](149, "a", 39);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](150, "Category Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](151, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](152, "a", 40);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](153, "Sub Category Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](154, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](155, "a", 41);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](156, "Redeem Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](157, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](158, "a", 42);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](159, "Taxed Products Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](160, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](161, "a", 43);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](162, "Wallet Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](163, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](164, "a", 44);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](165, "Return & Cancel Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](166, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](167, "a", 45);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](168, "R&C Product Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](169, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](170, "a", 46);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](171, "Profit & loss");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](172, "li", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](173, "a", 47);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](174, "Stats");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](175, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](176, "a", 48);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](177, "span", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](178, " settings_suggest ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](179, "span", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](180, "Settings");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵattribute"]("src", ctx.assetUrl + "/icon.png", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵsanitizeUrl"]);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵproperty"]("ngClass", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵpureFunction1"](2, _c0, !ctx.open));
    } }, directives: [_angular_common__WEBPACK_IMPORTED_MODULE_2__.NgClass, _angular_router__WEBPACK_IMPORTED_MODULE_3__.RouterLinkWithHref], styles: [".sidenav-bar[_ngcontent-%COMP%] {\n  background-color: #40404010 !important;\n  height: 100vh;\n  overflow-x: auto;\n  padding: 0px;\n}\n\n.sidenav-bar[_ngcontent-%COMP%]::-webkit-scrollbar {\n  display: none;\n}\n\n.sidenav-logo[_ngcontent-%COMP%] {\n  width: 45px;\n  margin-top: 20px;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%] {\n  padding: 10px;\n  margin-bottom: 5px;\n  background-color: white;\n  margin: 8px;\n  align-items: center;\n  justify-content: center;\n  border-radius: 8px;\n  border: 1px solid #40404020;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 10pt;\n  font-family: \"Poppins\", sans-serif;\n  text-align: center;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]::after {\n  display: none;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%]:first-child {\n  font-size: 14pt !important;\n  margin-right: 20px;\n  color: black !important;\n  border-radius: 10px;\n  margin-left: 10px;\n}\n\n.is-closed[_ngcontent-%COMP%]    > .sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%]:first-child {\n  margin-left: 0px;\n  display: flex;\n  justify-content: center;\n  align-items: center;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]:hover    > a[_ngcontent-%COMP%], .sidenav-menu[_ngcontent-%COMP%]    > li.uk-active[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%], .sidenav-menu[_ngcontent-%COMP%]    > li.uk-open[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: #120E43 !important;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span.chev-down[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 12pt;\n  margin-left: 30px;\n}\n\n.sidenav-menu[_ngcontent-%COMP%]    > li.uk-open[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span.chev-down[_ngcontent-%COMP%] {\n  transform: rotate(90deg);\n}\n\n.is-closed[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]   .uk-nav-sub[_ngcontent-%COMP%], .is-closed[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]   span.menu-title[_ngcontent-%COMP%], .is-closed[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]   span.chev-down[_ngcontent-%COMP%] {\n  display: none !important;\n}\n\n.sidenav-dropdown[_ngcontent-%COMP%] {\n  padding: 8px 4px;\n}\n\n.sidenav-dropdown[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 9.5pt;\n}\n\n.uk-nav-sub[_ngcontent-%COMP%] {\n  margin-left: 20px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNpZGVuYXZiYXIuY29tcG9uZW50LnNjc3MiLCIuLlxcLi5cXC4uXFxzdHlsZXNcXF9taXhpbnMuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFDQTtFQUNJLHNDQ0ZTO0VER1QsYUFBQTtFQUNBLGdCQUFBO0VBQ0EsWUFBQTtBQUFKOztBQUdBO0VBQ0ksYUFBQTtBQUFKOztBQUdBO0VBQ0ksV0FBQTtFQUNBLGdCQUFBO0FBQUo7O0FBR0E7RUFDSSxhQUFBO0VBQ0Esa0JBQUE7RUFDQSx1QkFBQTtFQUNBLFdBQUE7RUFDQSxtQkFBQTtFQUNBLHVCQUFBO0VBQ0Esa0JBQUE7RUFDQSwyQkFBQTtBQUFKOztBQUdBO0VBQ0ksWUFBQTtFQUNBLGVBQUE7RUFDQSxrQ0FBQTtFQUNBLGtCQUFBO0FBQUo7O0FBR0E7RUFDSSxhQUFBO0FBQUo7O0FBR0E7RUFDSSwwQkFBQTtFQUNBLGtCQUFBO0VBQ0EsdUJBQUE7RUFDQSxtQkFBQTtFQUNBLGlCQUFBO0FBQUo7O0FBR0E7RUFDSSxnQkFBQTtFQUNBLGFBQUE7RUFDQSx1QkFBQTtFQUNBLG1CQUFBO0FBQUo7O0FBR0E7OztFQUdJLHlCQ3hEWTtBRHdEaEI7O0FBR0E7RUFDSSxZQUFBO0VBQ0EsZUFBQTtFQUNBLGlCQUFBO0FBQUo7O0FBR0E7RUFDSSx3QkFBQTtBQUFKOztBQUdBOzs7RUFHSSx3QkFBQTtBQUFKOztBQUdBO0VBQ0ksZ0JBQUE7QUFBSjs7QUFHQTtFQUNJLFlBQUE7RUFDQSxnQkFBQTtBQUFKOztBQUdBO0VBQ0ksaUJBQUE7QUFBSiIsImZpbGUiOiJzaWRlbmF2YmFyLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiQGltcG9ydCAnX21peGlucyc7XHJcbi5zaWRlbmF2LWJhciB7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAkZ3JheS1jb2xvcjtcclxuICAgIGhlaWdodDogMTAwdmg7XHJcbiAgICBvdmVyZmxvdy14OiBhdXRvO1xyXG4gICAgcGFkZGluZzogMHB4O1xyXG59XHJcblxyXG4uc2lkZW5hdi1iYXI6Oi13ZWJraXQtc2Nyb2xsYmFyIHtcclxuICAgIGRpc3BsYXk6IG5vbmU7XHJcbn1cclxuXHJcbi5zaWRlbmF2LWxvZ28ge1xyXG4gICAgd2lkdGg6IDQ1cHg7XHJcbiAgICBtYXJnaW4tdG9wOiAyMHB4O1xyXG59XHJcblxyXG4uc2lkZW5hdi1tZW51PmxpIHtcclxuICAgIHBhZGRpbmc6IDEwcHg7XHJcbiAgICBtYXJnaW4tYm90dG9tOiA1cHg7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiB3aGl0ZTtcclxuICAgIG1hcmdpbjogOHB4O1xyXG4gICAgYWxpZ24taXRlbXM6IGNlbnRlcjtcclxuICAgIGp1c3RpZnktY29udGVudDogY2VudGVyO1xyXG4gICAgYm9yZGVyLXJhZGl1czogOHB4O1xyXG4gICAgYm9yZGVyOiAxcHggc29saWQgIzQwNDA0MDIwO1xyXG59XHJcblxyXG4uc2lkZW5hdi1tZW51PmxpPmEge1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZm9udC1zaXplOiAxMHB0O1xyXG4gICAgZm9udC1mYW1pbHk6ICdQb3BwaW5zJywgc2Fucy1zZXJpZjtcclxuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcclxufVxyXG5cclxuLnNpZGVuYXYtbWVudT5saT5hOjphZnRlciB7XHJcbiAgICBkaXNwbGF5OiBub25lO1xyXG59XHJcblxyXG4uc2lkZW5hdi1tZW51PmxpPmE+c3BhbjpmaXJzdC1jaGlsZCB7XHJcbiAgICBmb250LXNpemU6IDE0cHQgIWltcG9ydGFudDtcclxuICAgIG1hcmdpbi1yaWdodDogMjBweDtcclxuICAgIGNvbG9yOiBibGFjayAhaW1wb3J0YW50O1xyXG4gICAgYm9yZGVyLXJhZGl1czogMTBweDtcclxuICAgIG1hcmdpbi1sZWZ0OiAxMHB4O1xyXG59XHJcblxyXG4uaXMtY2xvc2VkPi5zaWRlbmF2LW1lbnU+bGk+YT5zcGFuOmZpcnN0LWNoaWxkIHtcclxuICAgIG1hcmdpbi1sZWZ0OiAwcHg7XHJcbiAgICBkaXNwbGF5OiBmbGV4O1xyXG4gICAganVzdGlmeS1jb250ZW50OiBjZW50ZXI7XHJcbiAgICBhbGlnbi1pdGVtczogY2VudGVyO1xyXG59XHJcblxyXG4uc2lkZW5hdi1tZW51PmxpOmhvdmVyPmEsXHJcbi5zaWRlbmF2LW1lbnU+bGkudWstYWN0aXZlPmEsXHJcbi5zaWRlbmF2LW1lbnU+bGkudWstb3Blbj5hIHtcclxuICAgIGNvbG9yOiAkcHJpbWFyeS1jb2xvcjtcclxufVxyXG5cclxuLnNpZGVuYXYtbWVudT5saT5hPnNwYW4uY2hldi1kb3duIHtcclxuICAgIGNvbG9yOiBibGFjaztcclxuICAgIGZvbnQtc2l6ZTogMTJwdDtcclxuICAgIG1hcmdpbi1sZWZ0OiAzMHB4O1xyXG59XHJcblxyXG4uc2lkZW5hdi1tZW51PmxpLnVrLW9wZW4+YT5zcGFuLmNoZXYtZG93biB7XHJcbiAgICB0cmFuc2Zvcm06IHJvdGF0ZSg5MGRlZyk7XHJcbn1cclxuXHJcbi5pcy1jbG9zZWQ+dWwgLnVrLW5hdi1zdWIsXHJcbi5pcy1jbG9zZWQ+dWwgc3Bhbi5tZW51LXRpdGxlLFxyXG4uaXMtY2xvc2VkPnVsIHNwYW4uY2hldi1kb3duIHtcclxuICAgIGRpc3BsYXk6IG5vbmUgIWltcG9ydGFudDtcclxufVxyXG5cclxuLnNpZGVuYXYtZHJvcGRvd24ge1xyXG4gICAgcGFkZGluZzogOHB4IDRweDtcclxufVxyXG5cclxuLnNpZGVuYXYtZHJvcGRvd24+YSB7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXNpemU6IDkuNXB0O1xyXG59XHJcblxyXG4udWstbmF2LXN1YiB7XHJcbiAgICBtYXJnaW4tbGVmdDogMjBweDtcclxufVxyXG4iLCIkZ3JheS1jb2xvcjogIzQwNDA0MDEwICFpbXBvcnRhbnQ7XHJcbiRwcmltYXJ5LWNvbG9yOiAjMTIwRTQzICFpbXBvcnRhbnQ7XHJcbiRzZWNvbmQtYmx1ZTogIzVEQTNGQTtcclxuJHAtZ3JlZW46ICMyMkNCNUM7XHJcbiRwLXJlZDogI0UyMTcxNzsiXX0= */"] });


/***/ }),

/***/ 6801:
/*!*******************************************************!*\
  !*** ./src/app/components/topnav/topnav.component.ts ***!
  \*******************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "TopnavComponent": () => (/* binding */ TopnavComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var src_app_auth_services_authentication_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! src/app/auth/_services/authentication.service */ 7893);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ 9895);




class TopnavComponent {
    constructor(authService, router) {
        this.authService = authService;
        this.router = router;
        this.open = false;
        this.openChange = new _angular_core__WEBPACK_IMPORTED_MODULE_1__.EventEmitter();
    }
    ngOnInit() {
    }
    toggle() {
        this.open = !this.open;
        this.openChange.emit(this.open);
    }
    logOut() {
        this.authService.logout();
        this.router.navigate(['/auth/login']);
    }
}
TopnavComponent.ɵfac = function TopnavComponent_Factory(t) { return new (t || TopnavComponent)(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](src_app_auth_services_authentication_service__WEBPACK_IMPORTED_MODULE_0__.AuthenticationService), _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdirectiveInject"](_angular_router__WEBPACK_IMPORTED_MODULE_2__.Router)); };
TopnavComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵdefineComponent"]({ type: TopnavComponent, selectors: [["app-topnav"]], inputs: { open: "open" }, outputs: { openChange: "openChange" }, decls: 28, vars: 1, consts: [["uk-navbar", "", 1, "uk-navbar-container", "topnav-bar"], [1, "uk-navbar-left"], [1, "uk-navbar-nav", 3, "click"], [1, "uk-active"], [1, "material-icons-sharp", 2, "font-size", "16pt"], [1, "uk-navbar-right"], [1, "uk-navbar-nav"], ["href", "#"], [1, "material-icons-sharp"], [1, "uk-navbar-dropdown", "uk-padding-remove"], [1, "uk-nav", "uk-navbar-dropdown-nav"], [1, "logout"], [3, "click"], [1, "material-icons-round"]], template: function TopnavComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](0, "nav", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](1, "div", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](2, "ul", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function TopnavComponent_Template_ul_click_2_listener() { return ctx.toggle(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](3, "li", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](4, "a");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](5, "span", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](7, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](8, "ul", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](9, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](10, "a", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](11, "span", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](12, " person ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](13, " Profile");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](14, "div", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](15, "ul", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](16, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](17, "a", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](18, "Edit Profile");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](19, "li", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](20, "a", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵlistener"]("click", function TopnavComponent_Template_a_click_20_listener() { return ctx.logOut(); });
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](21, "span", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](22, " logout ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](23, " Logout");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](24, "li");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](25, "a", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementStart"](26, "span", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtext"](27, " fullscreen ");
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵelementEnd"]();
    } if (rf & 2) {
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵadvance"](6);
        _angular_core__WEBPACK_IMPORTED_MODULE_1__["ɵɵtextInterpolate1"](" ", ctx.open ? "menu_open" : "menu", " ");
    } }, styles: [".topnav-bar[_ngcontent-%COMP%]    > div[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  text-transform: capitalize;\n  color: black;\n  font-size: 10pt;\n}\n\n.topnav-bar[_ngcontent-%COMP%]    > div[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 14pt;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%] {\n  margin-top: 0px !important;\n  border-bottom-left-radius: 8px;\n  border-bottom-right-radius: 8px;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%] {\n  padding: 5px 15px;\n  margin: 4px;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 10pt;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li.logout[_ngcontent-%COMP%] {\n  background-color: #f80202;\n  color: white !important;\n  border-bottom-left-radius: 8px;\n  border-bottom-right-radius: 8px;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li.logout[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%] {\n  color: white;\n}\n\n.uk-navbar-dropdown[_ngcontent-%COMP%]    > ul[_ngcontent-%COMP%]    > li.logout[_ngcontent-%COMP%]    > a[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  font-size: 10pt;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInRvcG5hdi5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtFQUNFLDBCQUFBO0VBQ0EsWUFBQTtFQUNBLGVBQUE7QUFDRjs7QUFFQTtFQUNFLFlBQUE7RUFDQSxlQUFBO0FBQ0Y7O0FBRUE7RUFDRSwwQkFBQTtFQUNBLDhCQUFBO0VBQ0EsK0JBQUE7QUFDRjs7QUFFQTtFQUNFLGlCQUFBO0VBQ0EsV0FBQTtBQUNGOztBQUVBO0VBQ0UsWUFBQTtFQUNBLGVBQUE7QUFDRjs7QUFFQTtFQUNFLHlCQUFBO0VBQ0EsdUJBQUE7RUFDQSw4QkFBQTtFQUNBLCtCQUFBO0FBQ0Y7O0FBRUE7RUFDRSxZQUFBO0FBQ0Y7O0FBRUE7RUFDRSxlQUFBO0FBQ0YiLCJmaWxlIjoidG9wbmF2LmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLnRvcG5hdi1iYXI+ZGl2PnVsPmxpPmEge1xyXG4gIHRleHQtdHJhbnNmb3JtOiBjYXBpdGFsaXplO1xyXG4gIGNvbG9yOiBibGFjaztcclxuICBmb250LXNpemU6IDEwcHQ7XHJcbn1cclxuXHJcbi50b3BuYXYtYmFyPmRpdj51bD5saT5hPnNwYW4ge1xyXG4gIGNvbG9yOiBibGFjaztcclxuICBmb250LXNpemU6IDE0cHQ7XHJcbn1cclxuXHJcbi51ay1uYXZiYXItZHJvcGRvd24ge1xyXG4gIG1hcmdpbi10b3A6IDBweCAhaW1wb3J0YW50O1xyXG4gIGJvcmRlci1ib3R0b20tbGVmdC1yYWRpdXM6IDhweDtcclxuICBib3JkZXItYm90dG9tLXJpZ2h0LXJhZGl1czogOHB4O1xyXG59XHJcblxyXG4udWstbmF2YmFyLWRyb3Bkb3duPnVsPmxpIHtcclxuICBwYWRkaW5nOiA1cHggMTVweDtcclxuICBtYXJnaW46IDRweDtcclxufVxyXG5cclxuLnVrLW5hdmJhci1kcm9wZG93bj51bD5saT5hIHtcclxuICBjb2xvcjogYmxhY2s7XHJcbiAgZm9udC1zaXplOiAxMHB0O1xyXG59XHJcblxyXG4udWstbmF2YmFyLWRyb3Bkb3duPnVsPmxpLmxvZ291dCB7XHJcbiAgYmFja2dyb3VuZC1jb2xvcjogI2Y4MDIwMjtcclxuICBjb2xvcjogd2hpdGUgIWltcG9ydGFudDtcclxuICBib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOiA4cHg7XHJcbiAgYm9yZGVyLWJvdHRvbS1yaWdodC1yYWRpdXM6IDhweDtcclxufVxyXG5cclxuLnVrLW5hdmJhci1kcm9wZG93bj51bD5saS5sb2dvdXQ+YSB7XHJcbiAgY29sb3I6IHdoaXRlO1xyXG59XHJcblxyXG4udWstbmF2YmFyLWRyb3Bkb3duPnVsPmxpLmxvZ291dD5hPnNwYW4ge1xyXG4gIGZvbnQtc2l6ZTogMTBwdDtcclxufVxyXG4iXX0= */"] });


/***/ }),

/***/ 5085:
/*!**************************************************************************!*\
  !*** ./src/app/desktop/reports/brand-reports/brand-reports.component.ts ***!
  \**************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "BrandReportsComponent": () => (/* binding */ BrandReportsComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ 3679);


class BrandReportsComponent {
    constructor() { }
    ngOnInit() {
    }
}
BrandReportsComponent.ɵfac = function BrandReportsComponent_Factory(t) { return new (t || BrandReportsComponent)(); };
BrandReportsComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: BrandReportsComponent, selectors: [["app-brand-reports"]], decls: 75, vars: 0, consts: [[1, "uk-container", "uk-container-xlarge", "uk-padding-small"], [1, "heading"], [1, "subheading"], ["uk-grid", "", 1, "uk-text-center", "uk-grid-small", "uk-grid-match"], [1, "uk-width-expand@m"], [1, "uk-card", "uk-padding-remove", "uk-text-left", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-3@m", "uk-text-center", "uk-grid-match"], [1, "uk-card", "stats-grid", "uk-padding-small", "uk-card-body"], [1, "uk-table", "uk-margin-remove", "uk-table-divider", "uk-text-left"], [1, "stats-icon"], [1, "material-icons-round"], [1, "stats-info"], [1, "uk-table", "uk-table-small", "uk-table-divider", "reports-table"], [1, "uk-width-1-4@m"], [1, "uk-card", "uk-padding-small", "filter-grid", "uk-card-body"], [1, "filter-heading"], ["uk-grid", "", 1, "uk-grid-small", "uk-text-left", "uk-margin-remove-top"], [1, "uk-width-1-1"], ["for", "form-stacked-text ", 1, "uk-form-label", "primary-label"], ["type", "date", "placeholder", "50", 1, "uk-input"], ["for", "form-stacked-text ", 1, "uk-form-label", "type-label"], ["id", "form-stacked-select", 1, "uk-select"], ["value", ""], [1, "uk-width-1-1", "uk-text-right"], [1, "uk-button", "uk-width-1-2", "s-btn"], [1, "uk-width-1-1@s", "uk-text-right"], ["uk-tooltip", "title: Download PDF; pos: bottom", 1, "uk-button", "filter-button"], ["uk-tooltip", "title: Download CSV; pos: bottom", 1, "uk-button", "filter-button"]], template: function BrandReportsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h2", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "p", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Brands Report ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](10, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "table", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](12, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](14, "td", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, " group ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "td", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "Total Brands ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](20, " 23992 ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](21, "table", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](22, "thead");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](23, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](24, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](25, "Date");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](26, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](27, "Brand Name");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](28, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](29, "Total Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](30, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](31, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](32, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](33, "12/02/2022");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](34, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](35, "Amul");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](36, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](37, "923");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](38, "div", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](39, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](40, "p", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](41, "Filters");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](42, "form", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](43, "div", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](44, "label", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](45, "Date Start");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](46, "input", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](47, "div", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](48, "label", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](49, "Date End");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](50, "input", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](51, "div", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](52, "label", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](53, "Group");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](54, "select", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](55, "option");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](56, "Days");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](57, "option");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](58, "Weeks");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](59, "option", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](60, "Months");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](61, "option", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](62, "Years");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](63, "option", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](64, "All");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](65, "div", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](66, "button", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](67, "Apply");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](68, "div", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](69, "button", 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](70, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](71, " download ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](72, "button", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](73, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](74, " article ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_1__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_1__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_1__.NgForm, _angular_forms__WEBPACK_IMPORTED_MODULE_1__.NgSelectOption, _angular_forms__WEBPACK_IMPORTED_MODULE_1__["ɵNgSelectMultipleOption"]], styles: [".heading[_ngcontent-%COMP%] {\r\n    font-size: 14pt;\r\n    font-weight: 500;\r\n    margin-bottom: 4px;\r\n}\r\n\r\n.subheading[_ngcontent-%COMP%] {\r\n    font-size: 11pt;\r\n    color: black;\r\n    margin-top: 0px;\r\n}\r\n\r\n.reports-table[_ngcontent-%COMP%] > thead[_ngcontent-%COMP%] > tr[_ngcontent-%COMP%] > th[_ngcontent-%COMP%] {\r\n    color: black;\r\n    font-size: 11pt;\r\n    font-weight: 500;\r\n}\r\n\r\n.reports-table[_ngcontent-%COMP%] > tbody[_ngcontent-%COMP%] > tr[_ngcontent-%COMP%] > td[_ngcontent-%COMP%] {\r\n    font-size: 10pt;\r\n    color: black;\r\n    font-weight: 400;\r\n}\r\n\r\n.filter-grid[_ngcontent-%COMP%] {\r\n    border-left: 1px solid #04040420;\r\n}\r\n\r\n.filter-heading[_ngcontent-%COMP%] {\r\n    font-size: 12pt;\r\n    color: black;\r\n    text-align: left;\r\n}\r\n\r\n.type-label[_ngcontent-%COMP%] {\r\n    font-size: 10pt;\r\n    color: black !important;\r\n    text-align: left;\r\n    display: inline-block;\r\n    margin-bottom: 12px !important;\r\n}\r\n\r\n.uk-input[_ngcontent-%COMP%] {\r\n    background-color: #04040410;\r\n    height: 44px;\r\n    border-radius: 6px;\r\n    color: black;\r\n    font-size: 10pt;\r\n    border: 1px solid #04040420;\r\n}\r\n\r\n.uk-select[_ngcontent-%COMP%] {\r\n    background-color: #04040410;\r\n    color: black;\r\n    font-size: 10pt;\r\n    border-radius: 6px;\r\n    border: 1px solid #04040420;\r\n}\r\n\r\n.filter-button[_ngcontent-%COMP%] {\r\n    vertical-align: middle;\r\n    background-color: white;\r\n    padding: 4px;\r\n    text-align: center;\r\n    margin-right: 10px;\r\n}\r\n\r\n.filter-button[_ngcontent-%COMP%] > span[_ngcontent-%COMP%] {\r\n    vertical-align: middle;\r\n    display: flex;\r\n    padding: 6px;\r\n    font-size: 14pt;\r\n}\r\n\r\n.filter-button[_ngcontent-%COMP%]:hover {\r\n    background-color: #04040420;\r\n    border-radius: 25px;\r\n}\r\n\r\n.primary-label[_ngcontent-%COMP%] {\r\n    font-size: 9pt;\r\n    color: black;\r\n    display: inline-block;\r\n    margin-bottom: 10px;\r\n}\r\n\r\n.s-btn[_ngcontent-%COMP%] {\r\n    background-color: #118026;\r\n    text-transform: capitalize;\r\n    color: white;\r\n    padding: 2px;\r\n    border-radius: 4px;\r\n}\r\n\r\n.stats-grid[_ngcontent-%COMP%] {\r\n    background-color: #04040402;\r\n    border: 1px solid #04040420;\r\n    border-radius: 16px;\r\n}\r\n\r\ntd[_ngcontent-%COMP%] {\r\n    cursor: pointer;\r\n}\r\n\r\n.stats-icon[_ngcontent-%COMP%] {\r\n    padding: 0px;\r\n    width: 30%;\r\n    vertical-align: middle;\r\n    text-align: left;\r\n    padding: 4px;\r\n    padding-right: 0px;\r\n}\r\n\r\n.stats-icon[_ngcontent-%COMP%] > span[_ngcontent-%COMP%] {\r\n    font-size: 20pt;\r\n    padding: 12px;\r\n    vertical-align: middle;\r\n    border-radius: 8px;\r\n    color: black;\r\n    background-color: #54d3cd23;\r\n}\r\n\r\n.stats-info[_ngcontent-%COMP%] {\r\n    width: auto;\r\n    padding: 4px 10px;\r\n    font-size: 9pt;\r\n    padding-left: 0px;\r\n    color: black;\r\n    text-align: left;\r\n    vertical-align: middle;\r\n}\r\n\r\n.stats-info[_ngcontent-%COMP%] > p[_ngcontent-%COMP%] {\r\n    font-size: 12pt;\r\n    font-weight: 600;\r\n}\r\n\r\n.stats-grid[_ngcontent-%COMP%]:hover {\r\n    background-color: #1827f5c5;\r\n}\r\n\r\n.stats-grid[_ngcontent-%COMP%]:hover > table[_ngcontent-%COMP%] > tbody[_ngcontent-%COMP%] > tr[_ngcontent-%COMP%] > td[_ngcontent-%COMP%], .stats-grid[_ngcontent-%COMP%]:hover > table[_ngcontent-%COMP%] > tbody[_ngcontent-%COMP%] > tr[_ngcontent-%COMP%] > td[_ngcontent-%COMP%] > span[_ngcontent-%COMP%] {\r\n    color: white !important;\r\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIi4uL2N1c3RvbWVyLW9yZGVyL2N1c3RvbWVyLW9yZGVyLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksZUFBZTtJQUNmLGdCQUFnQjtJQUNoQixrQkFBa0I7QUFDdEI7O0FBRUE7SUFDSSxlQUFlO0lBQ2YsWUFBWTtJQUNaLGVBQWU7QUFDbkI7O0FBRUE7SUFDSSxZQUFZO0lBQ1osZUFBZTtJQUNmLGdCQUFnQjtBQUNwQjs7QUFFQTtJQUNJLGVBQWU7SUFDZixZQUFZO0lBQ1osZ0JBQWdCO0FBQ3BCOztBQUVBO0lBQ0ksZ0NBQWdDO0FBQ3BDOztBQUVBO0lBQ0ksZUFBZTtJQUNmLFlBQVk7SUFDWixnQkFBZ0I7QUFDcEI7O0FBRUE7SUFDSSxlQUFlO0lBQ2YsdUJBQXVCO0lBQ3ZCLGdCQUFnQjtJQUNoQixxQkFBcUI7SUFDckIsOEJBQThCO0FBQ2xDOztBQUVBO0lBQ0ksMkJBQTJCO0lBQzNCLFlBQVk7SUFDWixrQkFBa0I7SUFDbEIsWUFBWTtJQUNaLGVBQWU7SUFDZiwyQkFBMkI7QUFDL0I7O0FBRUE7SUFDSSwyQkFBMkI7SUFDM0IsWUFBWTtJQUNaLGVBQWU7SUFDZixrQkFBa0I7SUFDbEIsMkJBQTJCO0FBQy9COztBQUVBO0lBQ0ksc0JBQXNCO0lBQ3RCLHVCQUF1QjtJQUN2QixZQUFZO0lBQ1osa0JBQWtCO0lBQ2xCLGtCQUFrQjtBQUN0Qjs7QUFFQTtJQUNJLHNCQUFzQjtJQUN0QixhQUFhO0lBQ2IsWUFBWTtJQUNaLGVBQWU7QUFDbkI7O0FBRUE7SUFDSSwyQkFBMkI7SUFDM0IsbUJBQW1CO0FBQ3ZCOztBQUVBO0lBQ0ksY0FBYztJQUNkLFlBQVk7SUFDWixxQkFBcUI7SUFDckIsbUJBQW1CO0FBQ3ZCOztBQUVBO0lBQ0kseUJBQXlCO0lBQ3pCLDBCQUEwQjtJQUMxQixZQUFZO0lBQ1osWUFBWTtJQUNaLGtCQUFrQjtBQUN0Qjs7QUFFQTtJQUNJLDJCQUEyQjtJQUMzQiwyQkFBMkI7SUFDM0IsbUJBQW1CO0FBQ3ZCOztBQUVBO0lBQ0ksZUFBZTtBQUNuQjs7QUFFQTtJQUNJLFlBQVk7SUFDWixVQUFVO0lBQ1Ysc0JBQXNCO0lBQ3RCLGdCQUFnQjtJQUNoQixZQUFZO0lBQ1osa0JBQWtCO0FBQ3RCOztBQUVBO0lBQ0ksZUFBZTtJQUNmLGFBQWE7SUFDYixzQkFBc0I7SUFDdEIsa0JBQWtCO0lBQ2xCLFlBQVk7SUFDWiwyQkFBMkI7QUFDL0I7O0FBRUE7SUFDSSxXQUFXO0lBQ1gsaUJBQWlCO0lBQ2pCLGNBQWM7SUFDZCxpQkFBaUI7SUFDakIsWUFBWTtJQUNaLGdCQUFnQjtJQUNoQixzQkFBc0I7QUFDMUI7O0FBRUE7SUFDSSxlQUFlO0lBQ2YsZ0JBQWdCO0FBQ3BCOztBQUVBO0lBQ0ksMkJBQTJCO0FBQy9COztBQUVBOztJQUVJLHVCQUF1QjtBQUMzQiIsImZpbGUiOiJicmFuZC1yZXBvcnRzLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmhlYWRpbmcge1xyXG4gICAgZm9udC1zaXplOiAxNHB0O1xyXG4gICAgZm9udC13ZWlnaHQ6IDUwMDtcclxuICAgIG1hcmdpbi1ib3R0b206IDRweDtcclxufVxyXG5cclxuLnN1YmhlYWRpbmcge1xyXG4gICAgZm9udC1zaXplOiAxMXB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgbWFyZ2luLXRvcDogMHB4O1xyXG59XHJcblxyXG4ucmVwb3J0cy10YWJsZT50aGVhZD50cj50aCB7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXNpemU6IDExcHQ7XHJcbiAgICBmb250LXdlaWdodDogNTAwO1xyXG59XHJcblxyXG4ucmVwb3J0cy10YWJsZT50Ym9keT50cj50ZCB7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXdlaWdodDogNDAwO1xyXG59XHJcblxyXG4uZmlsdGVyLWdyaWQge1xyXG4gICAgYm9yZGVyLWxlZnQ6IDFweCBzb2xpZCAjMDQwNDA0MjA7XHJcbn1cclxuXHJcbi5maWx0ZXItaGVhZGluZyB7XHJcbiAgICBmb250LXNpemU6IDEycHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICB0ZXh0LWFsaWduOiBsZWZ0O1xyXG59XHJcblxyXG4udHlwZS1sYWJlbCB7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcclxuICAgIHRleHQtYWxpZ246IGxlZnQ7XHJcbiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAxMnB4ICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbi51ay1pbnB1dCB7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjMDQwNDA0MTA7XHJcbiAgICBoZWlnaHQ6IDQ0cHg7XHJcbiAgICBib3JkZXItcmFkaXVzOiA2cHg7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBib3JkZXI6IDFweCBzb2xpZCAjMDQwNDA0MjA7XHJcbn1cclxuXHJcbi51ay1zZWxlY3Qge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzA0MDQwNDEwO1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZm9udC1zaXplOiAxMHB0O1xyXG4gICAgYm9yZGVyLXJhZGl1czogNnB4O1xyXG4gICAgYm9yZGVyOiAxcHggc29saWQgIzA0MDQwNDIwO1xyXG59XHJcblxyXG4uZmlsdGVyLWJ1dHRvbiB7XHJcbiAgICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7XHJcbiAgICBwYWRkaW5nOiA0cHg7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBtYXJnaW4tcmlnaHQ6IDEwcHg7XHJcbn1cclxuXHJcbi5maWx0ZXItYnV0dG9uPnNwYW4ge1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIGRpc3BsYXk6IGZsZXg7XHJcbiAgICBwYWRkaW5nOiA2cHg7XHJcbiAgICBmb250LXNpemU6IDE0cHQ7XHJcbn1cclxuXHJcbi5maWx0ZXItYnV0dG9uOmhvdmVyIHtcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICMwNDA0MDQyMDtcclxuICAgIGJvcmRlci1yYWRpdXM6IDI1cHg7XHJcbn1cclxuXHJcbi5wcmltYXJ5LWxhYmVsIHtcclxuICAgIGZvbnQtc2l6ZTogOXB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcclxufVxyXG5cclxuLnMtYnRuIHtcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICMxMTgwMjY7XHJcbiAgICB0ZXh0LXRyYW5zZm9ybTogY2FwaXRhbGl6ZTtcclxuICAgIGNvbG9yOiB3aGl0ZTtcclxuICAgIHBhZGRpbmc6IDJweDtcclxuICAgIGJvcmRlci1yYWRpdXM6IDRweDtcclxufVxyXG5cclxuLnN0YXRzLWdyaWQge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzA0MDQwNDAyO1xyXG4gICAgYm9yZGVyOiAxcHggc29saWQgIzA0MDQwNDIwO1xyXG4gICAgYm9yZGVyLXJhZGl1czogMTZweDtcclxufVxyXG5cclxudGQge1xyXG4gICAgY3Vyc29yOiBwb2ludGVyO1xyXG59XHJcblxyXG4uc3RhdHMtaWNvbiB7XHJcbiAgICBwYWRkaW5nOiAwcHg7XHJcbiAgICB3aWR0aDogMzAlO1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIHRleHQtYWxpZ246IGxlZnQ7XHJcbiAgICBwYWRkaW5nOiA0cHg7XHJcbiAgICBwYWRkaW5nLXJpZ2h0OiAwcHg7XHJcbn1cclxuXHJcbi5zdGF0cy1pY29uPnNwYW4ge1xyXG4gICAgZm9udC1zaXplOiAyMHB0O1xyXG4gICAgcGFkZGluZzogMTJweDtcclxuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XHJcbiAgICBib3JkZXItcmFkaXVzOiA4cHg7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjNTRkM2NkMjM7XHJcbn1cclxuXHJcbi5zdGF0cy1pbmZvIHtcclxuICAgIHdpZHRoOiBhdXRvO1xyXG4gICAgcGFkZGluZzogNHB4IDEwcHg7XHJcbiAgICBmb250LXNpemU6IDlwdDtcclxuICAgIHBhZGRpbmctbGVmdDogMHB4O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgdGV4dC1hbGlnbjogbGVmdDtcclxuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XHJcbn1cclxuXHJcbi5zdGF0cy1pbmZvPnAge1xyXG4gICAgZm9udC1zaXplOiAxMnB0O1xyXG4gICAgZm9udC13ZWlnaHQ6IDYwMDtcclxufVxyXG5cclxuLnN0YXRzLWdyaWQ6aG92ZXIge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzE4MjdmNWM1O1xyXG59XHJcblxyXG4uc3RhdHMtZ3JpZDpob3Zlcj50YWJsZT50Ym9keT50cj50ZCxcclxuLnN0YXRzLWdyaWQ6aG92ZXI+dGFibGU+dGJvZHk+dHI+dGQ+c3BhbiB7XHJcbiAgICBjb2xvcjogd2hpdGUgIWltcG9ydGFudDtcclxufVxyXG4iXX0= */"] });


/***/ }),

/***/ 202:
/*!****************************************************************************!*\
  !*** ./src/app/desktop/reports/customer-order/customer-order.component.ts ***!
  \****************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomerOrderComponent": () => (/* binding */ CustomerOrderComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ 3679);


class CustomerOrderComponent {
    constructor() { }
    ngOnInit() {
    }
}
CustomerOrderComponent.ɵfac = function CustomerOrderComponent_Factory(t) { return new (t || CustomerOrderComponent)(); };
CustomerOrderComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: CustomerOrderComponent, selectors: [["app-customer-order"]], decls: 79, vars: 0, consts: [[1, "uk-container", "uk-container-xlarge", "uk-padding-small"], [1, "heading"], [1, "subheading"], ["uk-grid", "", 1, "uk-text-center", "uk-grid-small", "uk-grid-match"], [1, "uk-width-expand@m"], [1, "uk-card", "uk-padding-remove", "uk-text-left", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-3@m", "uk-text-center", "uk-grid-match"], [1, "uk-card", "stats-grid", "uk-padding-small", "uk-card-body"], [1, "uk-table", "uk-margin-remove", "uk-table-divider", "uk-text-left"], [1, "stats-icon"], [1, "material-icons-round"], [1, "stats-info"], [1, "uk-table", "uk-table-small", "uk-table-divider", "reports-table"], [1, "r-symbol"], [1, "uk-width-1-4@m"], [1, "uk-card", "uk-padding-small", "filter-grid", "uk-card-body"], [1, "filter-heading"], ["uk-grid", "", 1, "uk-grid-small", "uk-text-left", "uk-margin-remove-top"], [1, "uk-width-1-1"], ["for", "form-stacked-text ", 1, "uk-form-label", "primary-label"], ["type", "date", "placeholder", "50", 1, "uk-input"], ["type", "text", "placeholder", "9900141870", 1, "uk-input"], [1, "uk-width-1-1", "uk-text-right"], [1, "uk-button", "uk-width-1-2", "s-btn"], [1, "uk-width-1-1@s", "uk-text-right"], ["uk-tooltip", "title: Download PDF; pos: bottom", 1, "uk-button", "filter-button"], ["uk-tooltip", "title: Download CSV; pos: bottom", 1, "uk-button", "filter-button"]], template: function CustomerOrderComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h2", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "p", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Customers Order Report ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](10, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "table", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](12, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](14, "td", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, " group ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "td", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "Avg. Orders ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](20, " 4.2 ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](21, "table", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](22, "thead");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](23, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](24, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](25, "Date");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](26, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](27, "Phone");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](28, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](29, "Name");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](30, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](31, "Orders");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](32, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](33, "Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](34, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](35, "Total");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](36, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](37, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](38, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](39, "12/02/2022");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](40, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](41, "9900141870");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](42, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](43, "Mehedi Hasan");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](44, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](45, "12");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](46, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](47, "Products");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](48, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](49, "span", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](50, "\u20B9 ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](51, "325.00");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](52, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](53, "div", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](54, "p", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](55, "Filters");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](56, "form", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](57, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](58, "label", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](59, "Date Start");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](60, "input", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](61, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](62, "label", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](63, "Date End");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](64, "input", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](65, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](66, "label", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](67, "Phone");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](68, "input", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](69, "div", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](70, "button", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](71, "Apply");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](72, "div", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](73, "button", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](74, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](75, " download ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](76, "button", 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](77, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](78, " article ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
    } }, directives: [_angular_forms__WEBPACK_IMPORTED_MODULE_1__["ɵNgNoValidate"], _angular_forms__WEBPACK_IMPORTED_MODULE_1__.NgControlStatusGroup, _angular_forms__WEBPACK_IMPORTED_MODULE_1__.NgForm], styles: [".heading[_ngcontent-%COMP%] {\n  font-size: 14pt;\n  font-weight: 500;\n  margin-bottom: 4px;\n}\n\n.subheading[_ngcontent-%COMP%] {\n  font-size: 11pt;\n  color: black;\n  margin-top: 0px;\n}\n\n.reports-table[_ngcontent-%COMP%]    > thead[_ngcontent-%COMP%]    > tr[_ngcontent-%COMP%]    > th[_ngcontent-%COMP%] {\n  color: black;\n  font-size: 11pt;\n  font-weight: 500;\n}\n\n.reports-table[_ngcontent-%COMP%]    > tbody[_ngcontent-%COMP%]    > tr[_ngcontent-%COMP%]    > td[_ngcontent-%COMP%] {\n  font-size: 10pt;\n  color: black;\n  font-weight: 400;\n}\n\n.filter-grid[_ngcontent-%COMP%] {\n  border-left: 1px solid #04040420;\n}\n\n.filter-heading[_ngcontent-%COMP%] {\n  font-size: 12pt;\n  color: black;\n  text-align: left;\n}\n\n.type-label[_ngcontent-%COMP%] {\n  font-size: 10pt;\n  color: black !important;\n  text-align: left;\n  display: inline-block;\n  margin-bottom: 12px !important;\n}\n\n.uk-input[_ngcontent-%COMP%] {\n  background-color: #04040410;\n  height: 44px;\n  border-radius: 6px;\n  color: black;\n  font-size: 10pt;\n  border: 1px solid #04040420;\n}\n\n.uk-select[_ngcontent-%COMP%] {\n  background-color: #04040410;\n  color: black;\n  font-size: 10pt;\n  border-radius: 6px;\n  border: 1px solid #04040420;\n}\n\n.filter-button[_ngcontent-%COMP%] {\n  vertical-align: middle;\n  background-color: white;\n  padding: 4px;\n  text-align: center;\n  margin-right: 10px;\n}\n\n.filter-button[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  vertical-align: middle;\n  display: flex;\n  padding: 6px;\n  font-size: 14pt;\n}\n\n.filter-button[_ngcontent-%COMP%]:hover {\n  background-color: #04040420;\n  border-radius: 25px;\n}\n\n.primary-label[_ngcontent-%COMP%] {\n  font-size: 9pt;\n  color: black;\n  display: inline-block;\n  margin-bottom: 10px;\n}\n\n.s-btn[_ngcontent-%COMP%] {\n  background-color: #118026;\n  text-transform: capitalize;\n  color: white;\n  padding: 2px;\n  border-radius: 4px;\n}\n\n.stats-grid[_ngcontent-%COMP%] {\n  background-color: #04040402;\n  border: 1px solid #04040420;\n  border-radius: 16px;\n}\n\ntd[_ngcontent-%COMP%] {\n  cursor: pointer;\n}\n\n.stats-icon[_ngcontent-%COMP%] {\n  padding: 0px;\n  width: 30%;\n  vertical-align: middle;\n  text-align: left;\n  padding: 4px;\n  padding-right: 0px;\n}\n\n.stats-icon[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  font-size: 20pt;\n  padding: 12px;\n  vertical-align: middle;\n  border-radius: 8px;\n  color: black;\n  background-color: #54d3cd23;\n}\n\n.stats-info[_ngcontent-%COMP%] {\n  width: auto;\n  padding: 4px 10px;\n  font-size: 9pt;\n  padding-left: 0px;\n  color: black;\n  text-align: left;\n  vertical-align: middle;\n}\n\n.stats-info[_ngcontent-%COMP%]    > p[_ngcontent-%COMP%] {\n  font-size: 12pt;\n  font-weight: 600;\n}\n\n.stats-grid[_ngcontent-%COMP%]:hover {\n  background-color: #1827f5c5;\n}\n\n.stats-grid[_ngcontent-%COMP%]:hover    > table[_ngcontent-%COMP%]    > tbody[_ngcontent-%COMP%]    > tr[_ngcontent-%COMP%]    > td[_ngcontent-%COMP%], .stats-grid[_ngcontent-%COMP%]:hover    > table[_ngcontent-%COMP%]    > tbody[_ngcontent-%COMP%]    > tr[_ngcontent-%COMP%]    > td[_ngcontent-%COMP%]    > span[_ngcontent-%COMP%] {\n  color: white !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbImN1c3RvbWVyLW9yZGVyLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksZUFBQTtFQUNBLGdCQUFBO0VBQ0Esa0JBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSxZQUFBO0VBQ0EsZUFBQTtBQUNKOztBQUVBO0VBQ0ksWUFBQTtFQUNBLGVBQUE7RUFDQSxnQkFBQTtBQUNKOztBQUVBO0VBQ0ksZUFBQTtFQUNBLFlBQUE7RUFDQSxnQkFBQTtBQUNKOztBQUVBO0VBQ0ksZ0NBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSxZQUFBO0VBQ0EsZ0JBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSx1QkFBQTtFQUNBLGdCQUFBO0VBQ0EscUJBQUE7RUFDQSw4QkFBQTtBQUNKOztBQUVBO0VBQ0ksMkJBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7RUFDQSxZQUFBO0VBQ0EsZUFBQTtFQUNBLDJCQUFBO0FBQ0o7O0FBRUE7RUFDSSwyQkFBQTtFQUNBLFlBQUE7RUFDQSxlQUFBO0VBQ0Esa0JBQUE7RUFDQSwyQkFBQTtBQUNKOztBQUVBO0VBQ0ksc0JBQUE7RUFDQSx1QkFBQTtFQUNBLFlBQUE7RUFDQSxrQkFBQTtFQUNBLGtCQUFBO0FBQ0o7O0FBRUE7RUFDSSxzQkFBQTtFQUNBLGFBQUE7RUFDQSxZQUFBO0VBQ0EsZUFBQTtBQUNKOztBQUVBO0VBQ0ksMkJBQUE7RUFDQSxtQkFBQTtBQUNKOztBQUVBO0VBQ0ksY0FBQTtFQUNBLFlBQUE7RUFDQSxxQkFBQTtFQUNBLG1CQUFBO0FBQ0o7O0FBRUE7RUFDSSx5QkFBQTtFQUNBLDBCQUFBO0VBQ0EsWUFBQTtFQUNBLFlBQUE7RUFDQSxrQkFBQTtBQUNKOztBQUVBO0VBQ0ksMkJBQUE7RUFDQSwyQkFBQTtFQUNBLG1CQUFBO0FBQ0o7O0FBRUE7RUFDSSxlQUFBO0FBQ0o7O0FBRUE7RUFDSSxZQUFBO0VBQ0EsVUFBQTtFQUNBLHNCQUFBO0VBQ0EsZ0JBQUE7RUFDQSxZQUFBO0VBQ0Esa0JBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSxhQUFBO0VBQ0Esc0JBQUE7RUFDQSxrQkFBQTtFQUNBLFlBQUE7RUFDQSwyQkFBQTtBQUNKOztBQUVBO0VBQ0ksV0FBQTtFQUNBLGlCQUFBO0VBQ0EsY0FBQTtFQUNBLGlCQUFBO0VBQ0EsWUFBQTtFQUNBLGdCQUFBO0VBQ0Esc0JBQUE7QUFDSjs7QUFFQTtFQUNJLGVBQUE7RUFDQSxnQkFBQTtBQUNKOztBQUVBO0VBQ0ksMkJBQUE7QUFDSjs7QUFFQTs7RUFFSSx1QkFBQTtBQUNKIiwiZmlsZSI6ImN1c3RvbWVyLW9yZGVyLmNvbXBvbmVudC5zY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmhlYWRpbmcge1xyXG4gICAgZm9udC1zaXplOiAxNHB0O1xyXG4gICAgZm9udC13ZWlnaHQ6IDUwMDtcclxuICAgIG1hcmdpbi1ib3R0b206IDRweDtcclxufVxyXG5cclxuLnN1YmhlYWRpbmcge1xyXG4gICAgZm9udC1zaXplOiAxMXB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgbWFyZ2luLXRvcDogMHB4O1xyXG59XHJcblxyXG4ucmVwb3J0cy10YWJsZT50aGVhZD50cj50aCB7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXNpemU6IDExcHQ7XHJcbiAgICBmb250LXdlaWdodDogNTAwO1xyXG59XHJcblxyXG4ucmVwb3J0cy10YWJsZT50Ym9keT50cj50ZCB7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXdlaWdodDogNDAwO1xyXG59XHJcblxyXG4uZmlsdGVyLWdyaWQge1xyXG4gICAgYm9yZGVyLWxlZnQ6IDFweCBzb2xpZCAjMDQwNDA0MjA7XHJcbn1cclxuXHJcbi5maWx0ZXItaGVhZGluZyB7XHJcbiAgICBmb250LXNpemU6IDEycHQ7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICB0ZXh0LWFsaWduOiBsZWZ0O1xyXG59XHJcblxyXG4udHlwZS1sYWJlbCB7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBjb2xvcjogYmxhY2sgIWltcG9ydGFudDtcclxuICAgIHRleHQtYWxpZ246IGxlZnQ7XHJcbiAgICBkaXNwbGF5OiBpbmxpbmUtYmxvY2s7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAxMnB4ICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbi51ay1pbnB1dCB7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjMDQwNDA0MTA7XHJcbiAgICBoZWlnaHQ6IDQ0cHg7XHJcbiAgICBib3JkZXItcmFkaXVzOiA2cHg7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBmb250LXNpemU6IDEwcHQ7XHJcbiAgICBib3JkZXI6IDFweCBzb2xpZCAjMDQwNDA0MjA7XHJcbn1cclxuXHJcbi51ay1zZWxlY3Qge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzA0MDQwNDEwO1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZm9udC1zaXplOiAxMHB0O1xyXG4gICAgYm9yZGVyLXJhZGl1czogNnB4O1xyXG4gICAgYm9yZGVyOiAxcHggc29saWQgIzA0MDQwNDIwO1xyXG59XHJcblxyXG4uZmlsdGVyLWJ1dHRvbiB7XHJcbiAgICB2ZXJ0aWNhbC1hbGlnbjogbWlkZGxlO1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogd2hpdGU7XHJcbiAgICBwYWRkaW5nOiA0cHg7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBtYXJnaW4tcmlnaHQ6IDEwcHg7XHJcbn1cclxuXHJcbi5maWx0ZXItYnV0dG9uPnNwYW4ge1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIGRpc3BsYXk6IGZsZXg7XHJcbiAgICBwYWRkaW5nOiA2cHg7XHJcbiAgICBmb250LXNpemU6IDE0cHQ7XHJcbn1cclxuXHJcbi5maWx0ZXItYnV0dG9uOmhvdmVyIHtcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICMwNDA0MDQyMDtcclxuICAgIGJvcmRlci1yYWRpdXM6IDI1cHg7XHJcbn1cclxuXHJcbi5wcmltYXJ5LWxhYmVsIHtcclxuICAgIGZvbnQtc2l6ZTogOXB0O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgZGlzcGxheTogaW5saW5lLWJsb2NrO1xyXG4gICAgbWFyZ2luLWJvdHRvbTogMTBweDtcclxufVxyXG5cclxuLnMtYnRuIHtcclxuICAgIGJhY2tncm91bmQtY29sb3I6ICMxMTgwMjY7XHJcbiAgICB0ZXh0LXRyYW5zZm9ybTogY2FwaXRhbGl6ZTtcclxuICAgIGNvbG9yOiB3aGl0ZTtcclxuICAgIHBhZGRpbmc6IDJweDtcclxuICAgIGJvcmRlci1yYWRpdXM6IDRweDtcclxufVxyXG5cclxuLnN0YXRzLWdyaWQge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzA0MDQwNDAyO1xyXG4gICAgYm9yZGVyOiAxcHggc29saWQgIzA0MDQwNDIwO1xyXG4gICAgYm9yZGVyLXJhZGl1czogMTZweDtcclxufVxyXG5cclxudGQge1xyXG4gICAgY3Vyc29yOiBwb2ludGVyO1xyXG59XHJcblxyXG4uc3RhdHMtaWNvbiB7XHJcbiAgICBwYWRkaW5nOiAwcHg7XHJcbiAgICB3aWR0aDogMzAlO1xyXG4gICAgdmVydGljYWwtYWxpZ246IG1pZGRsZTtcclxuICAgIHRleHQtYWxpZ246IGxlZnQ7XHJcbiAgICBwYWRkaW5nOiA0cHg7XHJcbiAgICBwYWRkaW5nLXJpZ2h0OiAwcHg7XHJcbn1cclxuXHJcbi5zdGF0cy1pY29uPnNwYW4ge1xyXG4gICAgZm9udC1zaXplOiAyMHB0O1xyXG4gICAgcGFkZGluZzogMTJweDtcclxuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XHJcbiAgICBib3JkZXItcmFkaXVzOiA4cHg7XHJcbiAgICBjb2xvcjogYmxhY2s7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjNTRkM2NkMjM7XHJcbn1cclxuXHJcbi5zdGF0cy1pbmZvIHtcclxuICAgIHdpZHRoOiBhdXRvO1xyXG4gICAgcGFkZGluZzogNHB4IDEwcHg7XHJcbiAgICBmb250LXNpemU6IDlwdDtcclxuICAgIHBhZGRpbmctbGVmdDogMHB4O1xyXG4gICAgY29sb3I6IGJsYWNrO1xyXG4gICAgdGV4dC1hbGlnbjogbGVmdDtcclxuICAgIHZlcnRpY2FsLWFsaWduOiBtaWRkbGU7XHJcbn1cclxuXHJcbi5zdGF0cy1pbmZvPnAge1xyXG4gICAgZm9udC1zaXplOiAxMnB0O1xyXG4gICAgZm9udC13ZWlnaHQ6IDYwMDtcclxufVxyXG5cclxuLnN0YXRzLWdyaWQ6aG92ZXIge1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogIzE4MjdmNWM1O1xyXG59XHJcblxyXG4uc3RhdHMtZ3JpZDpob3Zlcj50YWJsZT50Ym9keT50cj50ZCxcclxuLnN0YXRzLWdyaWQ6aG92ZXI+dGFibGU+dGJvZHk+dHI+dGQ+c3BhbiB7XHJcbiAgICBjb2xvcjogd2hpdGUgIWltcG9ydGFudDtcclxufVxyXG4iXX0= */"] });


/***/ }),

/***/ 4649:
/*!********************************************************************************!*\
  !*** ./src/app/desktop/reports/customer-reports/customer-reports.component.ts ***!
  \********************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomerReportsComponent": () => (/* binding */ CustomerReportsComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ 3679);


class CustomerReportsComponent {
    constructor() { }
    ngOnInit() {
    }
}
CustomerReportsComponent.ɵfac = function CustomerReportsComponent_Factory(t) { return new (t || CustomerReportsComponent)(); };
CustomerReportsComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: CustomerReportsComponent, selectors: [["app-customer-reports"]], decls: 77, vars: 0, consts: [[1, "uk-container", "uk-container-xlarge", "uk-padding-small"], [1, "heading"], [1, "subheading"], ["uk-grid", "", 1, "uk-text-center", "uk-grid-small", "uk-grid-match"], [1, "uk-width-expand@m"], [1, "uk-card", "uk-padding-remove", "uk-text-left", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-3@m", "uk-text-center", "uk-grid-match"], [1, "uk-card", "stats-grid", "uk-padding-small", "uk-card-body"], [1, "uk-table", "uk-margin-remove", "uk-table-divider", "uk-text-left"], [1, "stats-icon"], [1, "material-icons-round"], [1, "stats-info"], [1, "uk-table", "uk-table-small", "uk-table-divider", "reports-table"], [1, "r-symbol"], [1, "uk-width-1-4@m"], [1, "uk-card", "uk-padding-small", "filter-grid", "uk-card-body"], [1, "filter-heading"], ["uk-grid", "", 1, "uk-grid-small", "uk-text-left", "uk-margin-remove-top"], [1, "uk-width-1-1"], ["for", "form-stacked-text ", 1, "uk-form-label", "primary-label"], ["type", "date", "placeholder", "50", 1, "uk-input"], ["for", "form-stacked-text ", 1, "uk-form-label", "type-label"], ["id", "form-stacked-select", 1, "uk-select"], ["value", ""], [1, "uk-width-1-1", "uk-text-right"], [1, "uk-button", "uk-width-1-2", "s-btn"], [1, "uk-width-1-1@s", "uk-text-right"], ["uk-tooltip", "title: Download PDF; pos: bottom", 1, "uk-button", "filter-button"], ["uk-tooltip", "title: Download CSV; pos: bottom", 1, "uk-button", "filter-button"]], template: function CustomerReportsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](1, "h2", 1);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](2, "Reports");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](3, "p", 2);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](4, "Customers Report ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](5, "div", 3);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](6, "div", 4);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](7, "div", 5);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](8, "div", 6);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](9, "div");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](10, "div", 7);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](11, "table", 8);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](12, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](13, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](14, "td", 9);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](15, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](16, " group ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](17, "td", 11);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](18, "Total Customers ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](19, "p");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](20, " 23992 ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](21, "table", 12);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](22, "thead");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](23, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](24, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](25, "Date");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](26, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](27, "Total Customers");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](28, "th");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](29, "Spendings");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](30, "tbody");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](31, "tr");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](32, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](33, "12/02/2022");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](34, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](35, "990010");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](36, "td");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](37, "span", 13);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](38, "\u20B9 ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](39, "325.00");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](40, "div", 14);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](41, "div", 15);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](42, "p", 16);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](43, "Filters");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](44, "form", 17);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](45, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](46, "label", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](47, "Date Start");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](48, "input", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](49, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](50, "label", 19);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](51, "Date End");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelement"](52, "input", 20);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](53, "div", 18);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](54, "label", 21);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](55, "Group");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](56, "select", 22);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](57, "option");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](58, "Days");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](59, "option");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](60, "Weeks");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](61, "option", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](62, "Months");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](63, "option", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](64, "Years");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](65, "option", 23);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](66, "All");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](67, "div", 24);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](68, "button", 25);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](69, "Apply");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](70, "div", 26);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](71, "button", 27);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](72, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](73, " download ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](74, "button", 28);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](75, "span", 10);
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](76, " article ");
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();


/***/ }),

/***/ 1225:
/*!******************************************************************************!*\
  !*** ./src/app/desktop/reports/product-reports/product-reports.component.ts ***!
  \******************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ProductReportsComponent": () => (/* binding */ ProductReportsComponent)
/* harmony export */ });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ 7716);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ 3679);


class ProductReportsComponent {
    constructor() { }
    ngOnInit() {
    }
}
ProductReportsComponent.ɵfac = function ProductReportsComponent_Factory(t) { return new (t || ProductReportsComponent)(); };
ProductReportsComponent.ɵcmp = /*@__PURE__*/ _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({ type: ProductReportsComponent, selectors: [["app-product-reports"]], decls: 93, vars: 0, consts: [[1, "uk-container", "uk-container-xlarge", "uk-padding-small"], [1, "heading"], [1, "subheading"], ["uk-grid", "", 1, "uk-text-center", "uk-grid-small", "uk-grid-match"], [1, "uk-width-expand@m"], [1, "uk-card", "uk-padding-remove", "uk-text-left", "uk-card-body"], ["uk-grid", "", 1, "uk-child-width-1-2@s", "uk-child-width-1-3@m", "uk-text-center", "uk-grid-match"], [1, "uk-card", "stats-grid", "uk-padding-small", "uk-card-body"], [1, "uk-table", "uk-margin-remove", "uk-table-divider", "uk-text-left"], [1, "stats-icon"], [1, "material-icons-round"], [1, "stats-info"], [1, "uk-table", "uk-table-small", "uk-table-divider", "reports-table"], [1, "r-symbol"], [1, "uk-width-1-4@m"], [1, "uk-card", "uk-padding-small", "filter-grid", "uk-card-body"], [1, "filter-heading"], ["uk-grid", "", 1, "uk-grid-small", "uk-text-left", "uk-margin-remove-top"], [1, "uk-width-1-1"], ["for", "form-stacked-text ", 1, "uk-form-label", "primary-label"], ["type", "date", "placeholder", "50", 1, "uk-input"], ["type", "text", "placeholder", "by id/name", 1, "uk-input"], ["for", "form-stacked-text ", 1, "uk-form-label", "type-label"], ["id", "form-stacked-select", 1, "uk-select"], ["value", ""], [1, "uk-width-1-1", "uk-text-right"], [1, "uk-button", "uk-width-1-2", "s-btn"], [1, "uk-width-1-1@s", "uk-text-right"], ["uk-tooltip", "title: Download PDF; pos: bottom", 1, "uk-button", "filter-button"], ["uk-tooltip", "title: Download CSV; pos: bottom", 1, "uk-button", "filter-button"]], template: function ProductReportsComponent_Template(rf, ctx) { if (rf & 1) {
        _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "div", 0);


/***/ }),

/***/ 2061:

"use strict";


    }
