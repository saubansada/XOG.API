(self.webpackChunkxog_ui=self.webpackChunkxog_ui||[]).push([[970],{5970:(t,e,n)=>{"use strict";n.r(e),n.d(e,{MobileModule:()=>h});var o=n(8583),r=n(639);let i=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-mobile-home"]],decls:1,vars:0,template:function(t,e){1&t&&r._uU(0,"home-works")},styles:["ngx-bottom-nav[_ngcontent-%COMP%]{position:absolute!important;bottom:0;width:100%}"]}),t})();var c=n(798),s=n(5076);function a(t,e){if(1&t&&(r.ynx(0),r.TgZ(1,"a",2),r._UZ(2,"span",3),r.TgZ(3,"span",4),r._uU(4),r.qZA(),r.qZA(),r.BQk()),2&t){const t=e.$implicit;r.xp6(1),r.ekj("mobile-nav-link--active",t.active),r.xp6(1),r.uIk("uk-icon","icon:"+t.icon+";ratio: 0.8"),r.xp6(1),r.Q6J("routerLink",t.routerLink),r.xp6(1),r.Oqu(t.label)}}let l=(()=>{class t{constructor(t){this.router=t,this.items=[]}get colorPrimary(){return"primary"===this.color}get accentPrimary(){return"accent"===this.color}get warnPrimary(){return"warn"===this.color}get hideLabels(){return this.items.length>4}clicked(t){this.router.navigate(t,{replaceUrl:!0})}}return t.\u0275fac=function(e){return new(e||t)(r.Y36(s.F0))},t.\u0275cmp=r.Xpm({type:t,selectors:[["ngx-bottom-nav"]],hostVars:6,hostBindings:function(t,e){2&t&&r.ekj("color-primary",e.colorPrimary)("color-accent",e.accentPrimary)("color-warn",e.warnPrimary)},inputs:{items:"items",color:"color"},decls:2,vars:1,consts:[[1,"mobile-nav"],[4,"ngFor","ngForOf"],[1,"mobile-nav-link"],[1,"mobile-nav-icon"],[1,"mobile-nav-text",3,"routerLink"]],template:function(t,e){1&t&&(r.TgZ(0,"nav",0),r.YNc(1,a,5,5,"ng-container",1),r.qZA()),2&t&&(r.xp6(1),r.Q6J("ngForOf",e.items))},directives:[o.sg,s.rH],styles:[".mobile-nav[_ngcontent-%COMP%]{position:fixed;bottom:0;width:100%;height:55px;box-shadow:0 0 3px #0003;background-color:#fff;overflow-x:auto}.mobile-nav-link[_ngcontent-%COMP%]{display:inline-flex;flex-direction:column;align-items:center;justify-content:center;flex-grow:1;min-width:20%;overflow:hidden;white-space:nowrap;font-family:sans-serif;font-size:13px;color:#444;text-decoration:none;-webkit-tap-highlight-color:transparent;transition:background-color .1s ease-in-out}.mobile-nav-link--active[_ngcontent-%COMP%], .mobile-nav-link[_ngcontent-%COMP%]:hover{text-decoration:none;color:#d43b0c}.mobile-nav-icon[_ngcontent-%COMP%]{font-size:14px!important}.mobile-nav-text[_ngcontent-%COMP%]{font-size:8pt!important}"]}),t})(),p=(()=>{class t{constructor(){this.showBottomNav=!0,this.items=[{icon:"home",label:"Home",routerLink:"",routerLinkParams:["home"]},{icon:"list",label:"Categories",routerLink:"categories",routerLinkParams:["categories"],active:!0},{icon:"cart",label:"Cart",routerLink:"cart",routerLinkParams:["cart"]},{icon:"tag",label:"Offers",routerLink:"offers",routerLinkParams:["offers"]},{icon:"user",label:"Profile",routerLink:"profile",routerLinkParams:["profile"]}]}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-mobile-layout"]],inputs:{title:"title"},decls:7,vars:2,consts:[[1,"root-div"],["color","primary",3,"ngClass","items"]],template:function(t,e){1&t&&(r._UZ(0,"br"),r.TgZ(1,"p"),r._uU(2,"Mobile Version"),r.qZA(),r._UZ(3,"br"),r.TgZ(4,"div",0),r._UZ(5,"router-outlet"),r._UZ(6,"ngx-bottom-nav",1),r.qZA()),2&t&&(r.xp6(6),r.Q6J("ngClass",e.showBottomNav?"displayBlock":"displayNone")("items",e.items))},directives:[s.lC,l,o.mk],styles:[""]}),t})(),u=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-cart"]],decls:2,vars:0,template:function(t,e){1&t&&(r.TgZ(0,"p"),r._uU(1,"cart works!"),r.qZA())},styles:[""]}),t})(),m=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-categories"]],decls:2,vars:0,template:function(t,e){1&t&&(r.TgZ(0,"p"),r._uU(1,"categories works!"),r.qZA())},styles:[""]}),t})(),f=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-offers"]],decls:0,vars:0,template:function(t,e){},styles:[""]}),t})(),g=(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-profiles"]],decls:2,vars:0,template:function(t,e){1&t&&(r.TgZ(0,"p"),r._uU(1,"profiles works!"),r.qZA())},styles:[""]}),t})();const d=[{path:"",component:p,children:[{path:"",component:i},{path:"products",component:(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-products"]],decls:2,vars:0,template:function(t,e){1&t&&(r.TgZ(0,"p"),r._uU(1,"products works!"),r.qZA())},styles:[""]}),t})()},{path:"products/details",component:(()=>{class t{constructor(){}ngOnInit(){}}return t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=r.Xpm({type:t,selectors:[["app-product-details"]],decls:2,vars:0,template:function(t,e){1&t&&(r.TgZ(0,"p"),r._uU(1,"product-details works!"),r.qZA())},styles:[""]}),t})()},{path:"categories",component:m},{path:"cart",component:u},{path:"offers",component:f},{path:"profile",component:g}]}];let h=(()=>{class t{}return t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=r.oAB({type:t}),t.\u0275inj=r.cJS({imports:[[c.m,o.ez,s.Bz.forChild(d)]]}),t})()}}]);