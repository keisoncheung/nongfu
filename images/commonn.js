
//倒影幻灯
var hdpage=0;
var hdtime=300;
var hdlength=$('#slide').find('li').length;
var delay=300;
var delaying=false;

$('#slide').find('li').each(function(i){
	//$(this).css({'visibility':'hidden'});
	$(this).find('img').each(function(){
		$(this).attr('data',$(this).attr('src')).attr('src','');
	});
	$(this).find('img').load(function(){
			if (i==1||i==5){
				this.width = 428;
				this.height = 227;
			}
			if (i==2||i==4){
				this.width = 243;
				this.height = 128;
			}
			if (i==0){
				this.width = 660;
				this.height = 350;
			}
			createReflexion(this.parentNode.parentNode,this,i);
	});	
	$(this).find('img').each(function(){
		$(this).attr('src',$(this).attr('data'));
	});
	
});
var autoPlay = setInterval(nextPlay,8000);
$('#slide').hover(function(){
	clearInterval(autoPlay);
},function(){
	autoPlay = setInterval(nextPlay,8000);
});
function nextPlay(){
	m0($('#slide').find('li').eq(hdpage));
	m1($('#slide').find('li').eq((hdpage-1<0)?hdlength-1:hdpage-1));
	m2($('#slide').find('li').eq((hdpage-2<0)?hdlength+hdpage-2:hdpage-2));
	m3($('#slide').find('li').eq((hdpage-3<0)?hdlength+hdpage-3:hdpage-3));
	m4($('#slide').find('li').eq((hdpage-4<0)?hdlength+hdpage-4:hdpage-4));
	m5($('#slide').find('li').eq((hdpage-5<0)?hdlength+hdpage-5:hdpage-5));
	$('.lim').find('img').eq(hdpage).removeClass('current');
	hdpage++;
	if(hdpage==hdlength)hdpage=0;
	$('.lim').find('img').eq(hdpage).addClass('current');
}
$('.prev').click(function(){
	if (delaying) return;
	btndelay();
	m4($('#slide').find('li').eq(hdpage));
	m5($('#slide').find('li').eq((hdpage-1<0)?hdlength-1:hdpage-1));
	m0($('#slide').find('li').eq((hdpage-2<0)?hdlength+hdpage-2:hdpage-2));
	m1($('#slide').find('li').eq((hdpage-3<0)?hdlength+hdpage-3:hdpage-3));
	m2($('#slide').find('li').eq((hdpage-4<0)?hdlength+hdpage-4:hdpage-4));
	m3($('#slide').find('li').eq((hdpage-5<0)?hdlength+hdpage-5:hdpage-5));
	$('.lim').find('img').eq(hdpage).removeClass('current');
	hdpage--;
	if(hdpage<0)hdpage=hdlength-1;
	$('.lim').find('img').eq(hdpage).addClass('current');
		
});
$('.next').click(function(){
	if (delaying) return;
	btndelay();	
	nextPlay();	
});
$('.lim').find('img').each(function(i){
	$(this).click(function(){
		if (delaying) return;
		btndelay();
		hdpage=i;
		$('.lim').find('img').removeClass('current').eq(i).addClass('current');	
		m5($('#slide').find('li').eq(hdpage).css({'visibility':'visible'}));
		m4($('#slide').find('li').eq((hdpage-1<0)?hdlength-1:hdpage-1).css({'visibility':'visible'}));
		m3($('#slide').find('li').eq((hdpage-2<0)?hdlength+hdpage-2:hdpage-2));
		m2($('#slide').find('li').eq((hdpage-3<0)?hdlength+hdpage-3:hdpage-3));
		m1($('#slide').find('li').eq((hdpage-4<0)?hdlength+hdpage-4:hdpage-4));
		m0($('#slide').find('li').eq((hdpage-5<0)?hdlength+hdpage-5:hdpage-5).css({'visibility':'visible'}));
		
	});
});
function btndelay(){
	delaying = true;
		var del= setInterval(function(){
			delaying = false;
			clearInterval(del);

		},delay);
}
function m0(o){
	o.find('.tb,.tt').hide().end().css({zIndex:5}).animate({left:76,top:88},hdtime);
	o.find('img').eq(0).animate({width:428,height:227},hdtime);
	if(document.createElement("canvas").getContext){
		o.find('canvas').animate({width:428,height:227,top:228},hdtime);
	}else{
		o.find('img').eq(1).animate({width:428,height:227,top:228},hdtime);
	}
}
function m1(o){
	o.find('.tb,.tt').hide();
	o.css({zIndex:4,'visibility':'visible'}).animate({left:20,top:146},hdtime);
	o.find('img').eq(0).animate({width:243,height:128},hdtime);
	if(document.createElement("canvas").getContext){
		o.find('canvas').animate({width:243,height:128,top:129},hdtime);
	}else{
		o.find('img').eq(1).animate({width:243,height:128,top:129},hdtime);
	}
}
function m2(o){
	o.css({left:160,top:15,'visibility':'hidden'});
}
function m3(o){
	o.find('.tb,.tt').hide();
	o.css({zIndex:4,'visibility':'visible'}).animate({left:707,top:146},hdtime);
	o.find('img').eq(0).animate({width:243,height:128},hdtime);
	if(document.createElement("canvas").getContext){
		o.find('canvas').animate({width:243,height:128,top:129},hdtime);
	}else{
		o.find('img').eq(1).animate({width:243,height:128,top:129},hdtime);
	}
}
function m4(o){
	o.find('.tb,.tt').hide().end().css({zIndex:5}).animate({left:455,top:88},hdtime);
	o.find('img').eq(0).animate({width:428,height:227},hdtime);
	if(document.createElement("canvas").getContext){
		o.find('canvas').animate({width:428,height:227,top:228},hdtime);
	}else{
		o.find('img').eq(1).animate({width:428,height:227,top:228},hdtime);
	}
}
function m5(o){
	o.css({zIndex:7}).animate({left:160,top:15},hdtime,function(){o.find('.tb,.tt').show()});
	o.find('img').eq(0).animate({width:660,height:350},hdtime);
	if(document.createElement("canvas").getContext){
		o.find('canvas').animate({width:660,height:350,top:351},hdtime);
	}else{
		o.find('img').eq(1).animate({width:660,height:350,top:351},hdtime);
	}
}


	function createReflexion (cont, img, i) {
		var flx = false;
		if (document.createElement("canvas").getContext) {
			flx = document.createElement("canvas");
			flx.width = img.width;
			flx.height = img.height;
			

			var context = flx.getContext("2d");
			context.translate(0, img.height);
			context.scale(1, -1);
			context.drawImage(img, 0, 0, img.width, img.height);
			context.globalCompositeOperation = "destination-out";
			var gradient = context.createLinearGradient(0, 0, 0, img.height * 2);
			gradient.addColorStop(1, "rgba(255, 255, 255, 0)");
			gradient.addColorStop(0, "rgba(255, 255, 255, 1)");
			context.fillStyle = gradient;
			context.fillRect(0, 0, img.width, img.height * 2);
			if (i!=3)$(cont).css({'visibility':'visible'});
		} else {
			/* ---- DXImageTransform ---- */
			flx     = document.createElement('img');
			
			flx.onload=function(){
				if (i!=3)$(cont).css({'visibility':'visible'});
			};
			flx.src = img.src;
			flx.style.filter = 'flipv progid:DXImageTransform.Microsoft.Alpha(' +
			                   'opacity=50, style=1, finishOpacity=0, startx=0, starty=0, finishx=0, finishy=' +
							   (img.height * .25) + ')';
			flx.width = img.width;
			flx.height = img.height;
		}
		/* ---- insert Reflexion ---- */
		flx.style.position = 'absolute';
		flx.style.left     = '0';
		flx.style.top     = (flx.height+1)+'px';
		cont.appendChild(flx);
		if (i==0){$(cont).css({zIndex:7}).find('.tb,.tt').show();}
		if (i==1){$(cont).css({left:455,top:88,zIndex:5});}
		if (i==5){$(cont).css({left:76,top:88,zIndex:5});}
		if (i==2){$(cont).css({left:707,top:146,zIndex:4});}
		if (i==4){$(cont).css({left:20,top:146,zIndex:4});}
		if (i==3){$(cont).css({zIndex:3});}
		//return flx;
	}
	//
if ($('.jj').height()>230){
	$('.jj').css({height:234,'overflow':'hidden'}).after('<div class="jbtn">+展开全部</div>').
	next().
	toggle(function(){
		$(this).html("-收起内容").prev().css({height:'auto'});
	},function(){
		$(this).html("+展开全部").prev().css({height:234});
	});	
}


function more_drop(obj, drop) {		//更多
  var obj = $("#" + obj);
  var drop = $("#" + drop);
  var client_width = document.body.clientWidth;
  var drop_width = drop.outerWidth(true);
  obj.hover(function () {
   var offset = obj.offset();
   var h = obj.height()-2;
   if (offset.left > client_width / 2) {
    drop.css({ "top": offset.top + h, "left": offset.left - drop_width + 60 });
   }
   else {
    drop.css({ "top": offset.top + h, "left": offset.left });
   }
   drop.show();
  }, function () {
   drop.hide();
  });
  drop.hover(function () { drop.show(); }, function () { drop.hide(); });
 }