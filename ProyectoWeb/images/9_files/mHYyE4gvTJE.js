/*!CK:1976966495!*//*1401566560,178179405*/

if (self.CavalryLogger) { CavalryLogger.start_js(["H\/9Of"]); }

__d("JSLoggerImpl",["Arbiter","AsyncRequest","Banzai","Env","ErrorUtils","JSLogger","JSLoggerConfig","OptionStorage","SystemEvents","copyProperties","emptyFunction","setTimeoutAcrossTransitions","BanzaiODS"],function(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r){var s=b('BanzaiODS').create(),t=l._,u,v='/ajax/chat/jslogger.php',w=l.create('jslogger'),x=-1,y=new n('JSLogger'),z={enabled_categories:null,categories:null,send_min:7500,send_max:60000};function aa(ka){return m[ka]||z[ka];}function ba(ka){var la=aa('enabled_categories')||{},ma=ka in la?la[ka]:la.__default;return ma;}function ca(ka,la,event){}function da(ka){var la=y.get('filter');if(console&&console[ka.type]&&la&&la.test(ka.cat)){var ma=(/(\d\d:\d\d:\d\d)/).test(new Date(ka.date))&&RegExp.$1,na=ma+' '+ka.cat+':'+ka.event;if(ka.data){console[ka.type](na,JSON.parse(ka.data));}else console[ka.type](na);}}function ea(ka){var la={page_id:t.pageId,env_start:j.start,now:Date.now()};if(ka){g.inform(l.DUMP_EVENT,ka);la.dumpData=ka;la.log=l.getEntries();}else{la.log=l.getEntries(function(ma){return (/log|warn|error/).test(ma.type)&&ba(ma.cat);},u);u=t.head;la.counts=t.counts;t.counts={};}return la;}function fa(ka,la,ma){var na=ea(ka);if(!ka){var oa=false;for(var pa in na.counts)oa=oa||pa!='jslogger';if(!oa&&na.log.length<=0)return;}if(i.isEnabled('jslogger')){delete na.counts;i.post('jslogger',na,{delay:0});s.flush();}else{na=JSON.stringify(na);var qa=new h().setURI(v+(ka?'?dump=1':'')).setMethod('POST').setData({clientState:na}).setReadOnly(true).setAllowCrossPageTransition(true);if(la)qa.setHandler(la);qa.setErrorHandler(ma||q);qa.send();}}function ga(){var ka=aa('send_min'),la=aa('send_max'),ma=ka*Math.pow(2,x+1);if(x>=0&&!t.forwarding){w.bump('send_t'+(ma<=la?x:'max'));fa();}x++;ma*=.75+Math.random()/2;r(ga,ma);}var ha=t.logAction;t.logAction=function(event,ka,la){ca(this.type,this.cat,event);var ma=ha.apply(this,arguments);if(i.isEnabled('jslogger'))if(this.type=='bump'){s.bumpEntityKey(this.cat,event,ka);}else if(this.type=='rate')s.bumpFraction(this.cat,event,ka?la:0,la);if(ma){da(ma);while(u&&(t.head.seq-u.seq)>t.MAX_HISTORY){u=u.next;w.bump('dropped_entries');}}var na=y.get('debugFilter');if(na&&na.test(event))debugger;};p(l,{setConsoleFilter:function(ka){if(!(ka instanceof RegExp))ka=ka?new RegExp(ka):null;y.set('filter',ka);},setDebugFilter:function(ka){if(!(ka instanceof RegExp))ka=ka?new RegExp(ka):null;y.set('debugFilter',ka);},replay:function(){for(var ka=t.tail;ka;ka=ka.next)da(ka);},getDumpJSON:function(ka){return ea({});},submitDump:function(ka,la){fa(ka||{},function(ma){var na=ma.getPayload();la(na);},function(){la(null);});},dump:function(ka){this.submitDump(ka,function(la){if(la){prompt('JSLogger dump now available at:',la);}else alert('Error while sending JSLogger dump');});}});ga();for(var ia=t.tail;ia;ia=ia.next)da(ia);var ja=l.create('sys');k.addListener(function(ka){if(ka.message=='Script error.'){ja.bump('xdomain_error');ja.debug('xdomain_error');}else ja.error('uncaught_exception',ka);});o.subscribe(o.ONLINE,function(ka,la){ja.warn(la?'online':'offline');});o.subscribe(o.USER,function(ka,la){ja.warn('user',{user:la});});o.subscribe(o.TIME_TRAVEL,function(ka,la){ja.warn('time_travel',{dt:la});});},null);