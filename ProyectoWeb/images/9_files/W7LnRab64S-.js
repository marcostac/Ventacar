/*!CK:324784233!*//*1407733291,*/

if (self.CavalryLogger) { CavalryLogger.start_js(["GjnVd"]); }

__d("SpotlightMessagesViewer",["ArbiterMixin","React","SpotlightViewer","SpotlightViewerAutoResize","SpotlightViewerBehaviorsMixin","SpotlightViewerClose","SpotlightViewerCoreMixin","SpotlightViewerDimensionMixin","SpotlightViewerPagers","SpotlightViewerPageWithKeys","SpotlightViewerThumbnailMixin","SpotlightViewerUnmountOnClose","SpotlightViewport","SubscriptionsHandler"],function(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t){var u=h.createClass({displayName:'SpotlightMessagesViewer',mixins:[g,k,m,q,n],behaviors:[p,r,j],componentWillUnmount:function(){this._subscriptions&&this._subscriptions.release();this._subscriptions=null;},getViewerID:function(){return this.props.setid;},getInitialState:function(){this._subscriptions=new t();return {photoData:this._getInitialPhotoData(),open:true};},_enableSubscriptions:function(){this.props.useloadingindicator&&this._subscriptions.addSubscriptions(this.viewState.subscribe('photo_fetch',this.setState.bind(this,{photoData:null},null)));},render:function(){var v=this.getMedia(),w=this.getStageDimensions(),x=this.props.useloadingindicator&&!this.state.photoData;return (h.createElement(i,{open:this.state.open,onHide:this.close},h.createElement(s,{onClick:this._onClickViewport,stageDimensions:w,media:v,showLoadingIndicator:x},h.createElement(l,{onClick:this.close}),this.props.disablepaging?null:h.createElement(o,null))));}});e.exports=u;},null);