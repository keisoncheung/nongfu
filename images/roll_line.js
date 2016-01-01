function ROLL(obj){
	if (!obj.o1 || !obj.o2 || !obj.d) return;
	this.obj=obj;
	this.o1=document.getElementById(obj.o1);
	this.o1.style.position="relative";
	this.o2=document.getElementById(obj.o2);
	this.o2.style.position="absolute";
	this.linum=this.o2.getElementsByTagName("li");
	this.isgd=true;
	if(this.linum.length==0) return;
}

ROLL.prototype={
	isgd:true,
	auto:function(){
		var self=this;
		if(self.obj.d=="top" || self.obj.d=="bottom"){
			self.r_y(self);
		}else if(self.obj.d=="left" || self.obj.d=="right"){
			self.r_x(self);
		}
	},
	r_y:function(self){
		var i=0,clone;
		var cd=self.linum.length;
		for(;i<cd;i++){
			clone=self.linum[i].cloneNode(true);
			self.o2.appendChild(clone);
		}		
		var oheight=self.linum[0] ? self.linum[0].offsetHeight : 0;
		var fanwei=cd*oheight;
		self.o2.style.height=self.linum.length*oheight+"px";
		if(self.obj.d=="top"){
			self.mk=window.setInterval(function(){self.rollingup(self,oheight,fanwei)},self.obj.j*1000);
		}else if(self.obj.d=="bottom"){
			self.mk=window.setInterval(function(){self.rollingdown(self,oheight,fanwei)},self.obj.j*1000)
		}
		
		if(self.obj.btnl){
			var ls=document.getElementById(self.obj.btnl);
			
			ls.onclick=function(){
				if(self.isgd!=false){
					clearInterval(self.mk);
					self.rollingdown(self,oheight,fanwei);
					({
					 "top":function(){self.mk=window.setInterval(function(){self.rollingup(self,oheight,fanwei)},self.obj.j*1000)},
					 "bottom":function(){self.mk=window.setInterval(function(){self.rollingdown(self,oheight,fanwei)},self.obj.j*1000)}
					 }[self.obj.d])();
				}
			}
		}
		if(self.obj.btnn){
			var nx=document.getElementById(self.obj.btnn);
			nx.onclick=function(){
				if(self.isgd!=false){
					clearInterval(self.mk);
					self.rollingup(self,oheight,fanwei);
					({
					 "top":function(){self.mk=window.setInterval(function(){self.rollingup(self,oheight,fanwei)},self.obj.j*1000)},
					 "bottom":function(){self.mk=window.setInterval(function(){self.rollingdown(self,oheight,fanwei)},self.obj.j*1000)}
					 }[self.obj.d])();
				}
			}
		}
		
	},
	rollingup:function(self,b,f){
		var t=0,a=10;
		self.isgd=false;
		self.nw=self.o2.offsetTop;
		if(!self.isgd){
			var moveo=setInterval(function(){
				self.o2.style.top=Math.ceil(self.ari(t,self.nw,-b,a)) + "px";
				if(self.o2.offsetTop<=-f){
					self.o2.style.top=0+"px";
					clearInterval(moveo);
					self.isgd=true;
				}
				if(t<a){t++}else{clearInterval(moveo);self.isgd=true;};
			},10);
		}
	},
	rollingdown:function(self,b,f){
		var t=0,a=10;
		self.isgd=false;
		self.nw=self.o2.offsetTop;
		if(!self.isgd){
			var moveo=setInterval(function(){
				self.o2.style.top=Math.ceil(self.ari(t,self.nw,b,a)) + "px";
				if(self.o2.offsetTop>=0){
					self.o2.style.top=-f+"px";
					clearInterval(moveo);
					self.isgd=true;
				}
				if(t<a){t++}else{clearInterval(moveo);self.isgd=true;};
			},10);
		}
	},
	//这里增加滚动方向以及效果的方法
	r_x:function(self){
		var i=0,clone;
		var cd=self.linum.length;
		for(;i<cd;i++){
			clone=self.linum[i].cloneNode(true);
			self.o2.appendChild(clone);
		}
		
		var owidth=self.linum[0].offsetWidth;
		var fanwei=cd*owidth;
		self.o2.style.width=self.linum.length*owidth+"px";
		
		if(self.obj.d=="left"){
			self.mk=window.setInterval(function(){self.rollingleft(self,owidth,fanwei)},self.obj.j*1000)
		}else if(self.obj.d=="right"){
			self.mk=window.setInterval(function(){self.rollingright(self,owidth,fanwei)},self.obj.j*1000)
		}
		
		if(self.obj.btnl){
			var ls=document.getElementById(self.obj.btnl);
			ls.onclick=function(){
				if(self.isgd!=false){
					clearInterval(self.mk);
					self.rollingright(self,owidth,fanwei);
					if(self.obj.d=="left"){
						self.mk=window.setInterval(function(){self.rollingleft(self,owidth,fanwei)},self.obj.j*1000)
					}else if(self.obj.d=="right"){
						self.mk=window.setInterval(function(){self.rollingright(self,owidth,fanwei)},self.obj.j*1000)
					}
				}
			}
		}
		if(self.obj.btnn){
			var nx=document.getElementById(self.obj.btnn);
			nx.onclick=function(){
				if(self.isgd!=false){
					clearInterval(self.mk);
					self.rollingleft(self,owidth,fanwei);
					if(self.obj.d=="left"){
						self.mk=window.setInterval(function(){self.rollingleft(self,owidth,fanwei)},self.obj.j*1000)
					}else if(self.obj.d=="right"){
						self.mk=window.setInterval(function(){self.rollingright(self,owidth,fanwei)},self.obj.j*1000)
					}
				}
			}
		}
		
	},
	rollingleft:function(self,b,f){
		var t=0,a=20;
		self.isgd=false;
		self.nw=self.o2.offsetLeft;
		if(!self.isgd){
			var moveo=setInterval(function(){
				self.o2.style.left=Math.ceil(self.ari(t,self.nw,-b,a)) + "px";
				if(self.o2.offsetLeft<=-f){
					self.o2.style.left=0+"px";
					clearInterval(moveo);
					self.isgd=true;
				}
				if(t<a){t++}else{clearInterval(moveo);self.isgd=true;};
			},10);
		}
	},
	rollingright:function(self,b,f){
		var self=this;
		var t=0,a=20;
		self.isgd=false;
		self.nw=self.o2.offsetLeft;
		if(!self.isgd){
			var moveo=setInterval(function(){
				self.o2.style.left=Math.ceil(self.ari(t,self.nw,b,a)) + "px";
				if(self.o2.offsetLeft>=0){
					self.o2.style.left=-f+"px";
					clearInterval(moveo);
					self.isgd=true;
				}
				if(t<a){t++}else{clearInterval(moveo);self.isgd=true;};
			},10);
		}
	},
	
	
	ari:function(t,b,c,d){
		return -c *(t/=d)*(t-2) + b; 
		//这里更换缓冲算法
	}
}