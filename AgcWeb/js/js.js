/*字体大小*/
$(document).ready(function() {
     $('#big').click(function()
    {
     $("#style_elements p").css("font-size","16px")
     $("#style_elements h1").css("font-size","20px")
    }
   );
     $('#small').click(function()
    {
     $("#style_elements p").css("font-size","12px")
     $("#style_elements h1").css("font-size","14px")
    }
   );
     $('#mid').click(function()
   {
     $("#style_elements p").css("font-size","14px")
     $("#style_elements h1").css("font-size","16px")
    }
   );
 }
);
/*产品树展开和关闭*/
//$(function(){
//    $(".m-expanded span").toggle(function(){
//			$(this).addClass("highlight");
//			$(this).next().show();
//	},function(){
//			$(this).removeClass("highlight");
//			$(this).next().hide();
//	});
//})

$(document).ready(function(){
var vFstLayerLink = $("ul#SideNav span");
	vFstLayerLink.click(function(event){
		var num = ($(this).parent("li")).find("ul");
		var len = num.length;
		if(len > 0){
			//var vClassName = ($(this).parent("li")).attr("class");
			//var flag = vClassName.indexOf("dis");
			//if(flag > 0){
				//alert(num[0]);
				//($(this).parent("li")).addClass("dis");
				
				var _this = ($(this).parent("li")).find("ul").eq(0);
				
				if(_this.attr("rel") == "" || _this.attr("rel") == null){
					_this.css("display","block");
					_this.attr("rel","current")
				}
				else{
					_this.css("display","none");
					_this.attr("rel","")	
				}
				
				//($(this).parent("li")).removeClass("dis");
			//}
			//else{
				//($(this).parent("li")).addClass("dis").siblings().removeClass("dis");
			//}
			return false;
		}
	});
});
//首页选项卡
$(function(){
	var $div_li =$("div.tab_menu ul li");
	$div_li.mouseover(function(){
		$(this).addClass("selected")            //当前<li>元素高亮
			   .siblings().removeClass("selected");  //去掉其它同辈<li>元素的高亮
		var index =  $div_li.index(this);  // 获取当前点击的<li>元素 在 全部li元素中的索引。
		$("div.tab_box > div")   	//选取子节点。不选取子节点的话，会引起错误。如果里面还有div 
				.eq(index).show()   //显示 <li>元素对应的<div>元素
				.siblings().hide(); //隐藏其它几个同辈的<div>元素
	})
})


function changeFontSize(){
	var d =document.getElementById('artCon');
	if(arguments[0]=='b'){
		d.className='article_con2';
	}else if(arguments[0]=='t'){
		d.className='article_con1';
	}else{
		d.className='article_con';
	}
	return false;
}

$(function(){
	$("#focus1").ppt({type:340});
	$(".men-list li img").hover(function(){$(this).css("border","5px solid #f0deb6")},function(){$(this).css("border","5px solid #575757")});
})
function closeAd(id){
	var d = document;
	d.getElementById(id).style.display="none";
}
//标记当前函数
function cur(ele,cls,tag){
	var ele= $(ele) || ele;
	var tag= tag || "";
	var mark= cls || "cur";
	ele.addClass(mark).siblings(tag).removeClass(mark);
}

//头图切换插件
$.fn.ppt=function(opt){
	var dft={
			type:560,
			auto:true,
			fout:200,
			fint:300,
			itvl:6000,
			anitime:300,
			act:"click",
			imgcon:".mimg",
			imgtag:"div",
			titles:"dl",
			startidx:0
			}
	if(opt){ $.extend(dft,opt); }	
	if(dft.type==340){
		dft.imgcon=".mpc";
		dft.titles="h3";
		$.extend(dft,opt);
	}
	var idx   = 0;
	var tmr   = false;	
	var _this = $(this);
	var mpc   = $(dft.imgcon , _this);
	var div   = $(dft.imgtag , mpc);
	var tit   = $(dft.titles , _this);
	_this.append("<ul></ul>")
	var ul    = $("ul" , _this);
	var mlen  = div.length;
	if(dft.type==340){
	  var tmpli=[];
	  for (i=0; i<mlen; i++){tmpli.push(i+1);}
	ul.html("<li>"+tmpli.join("<\/li><li>")+"<\/li>");
	}
	var li     = $("li", ul);
	var curdiv = div.eq(dft.startidx);
	var curtit = tit.eq(dft.startidx);
	cur(li.eq(dft.startidx));
	function play(){
		cur(li.eq(idx));
		curdiv.fadeOut( 
			dft.fout,			
			function(){div.eq(idx).fadeIn(dft.fint);}
				);
		curtit.slideUp(
				dft.anitime,
				function(){tit.eq(idx).slideDown(dft.anitime);}				
				);
		curdiv=div.eq(idx);
		curtit=tit.eq(idx);
		}
		
	if(dft.startidx){
		idx=dft.startidx;
		play();
		}
	li.bind(dft.act,function(){
		if($(this).hasClass("cur")) return;
		idx=$(this).index();
		play();
		$(this).find("a").blur();
		})
	if(dft.auto){start();}
	_this.hover(function(){ pause()},function(){start()});
    function step(){				
			    idx++;
				if(idx==mlen){idx=0;}
				play();
	}
	function pause(){
		if(tmr){
			 clearInterval(tmr);
			 tmr=false;
			};
	}	
	function start(){
		tmr=setInterval(step, dft.itvl);
	}
}
var FocusPic = function(BigPicID, SmallPicsID, TitleID, MemoID, width, height) {
    this.Data = [];
    this.ImgLoad = [];
    this.TimeOut = 3000;
    var isIE = navigator.appVersion.indexOf("MSIE") != -1 ? true: false;
    this.width = width;
    this.height = height;
    this.adNum = 0;
    var TimeOutObj;
    if (!FocusPic.childs) {
        FocusPic.childs = []
    };
    this.showTime = null;
    this.showSum = 10;
    this.ID = FocusPic.childs.push(this) - 1;
    this.Add = function(BigPic, SmallPic, Title, Url, Memo) {
        var ls;
        this.Data.push([BigPic, SmallPic, Title, Url, Memo]);
        ls = this.ImgLoad.length;
        this.ImgLoad.push(new Image);
        this.ImgLoad[ls].src = BigPic
    };

    this.TimeOutBegin = function() {
        clearInterval(TimeOutObj);
        TimeOutObj = setInterval("FocusPic.childs[" + this.ID + "].next()", this.TimeOut)
    };
    this.TimeOutEnd = function() {
        clearInterval(TimeOutObj)
    };

    this.select = function(num) {
        if (num > this.Data.length - 1) {
            return
        };
        if (num == this.adNum) {
            return
        };
        this.TimeOutBegin();
        if (BigPicID) {
            if (this.$(BigPicID)) {
                var aObj = this.$(BigPicID).getElementsByTagName("a")[0];
                aObj.href = this.Data[num][2];
                if (this.aImgY) {
                    this.aImgY.style.display = 'none';
                    this.aImg.style.zIndex = 0
                };
                this.aImgY = this.$('F' + this.ID + 'BF' + this.adNum);
                this.aImg = this.$('F' + this.ID + 'BF' + num);
                clearTimeout(this.showTime);
                this.showSum = 10;
                this.showTime = setTimeout("FocusPic.childs[" + this.ID + "].show()", 5)
            }
        };
        if (TitleID) {
            if (this.$(TitleID)) {
                this.$(TitleID).innerHTML = "<a href='" + this.Data[num][2] + "' target='_blank'>" + this.Data[num][3] + "</a>"
            }
        };
        if (MemoID) {
            if (this.$(MemoID)) {
                this.$(MemoID).innerHTML = this.Data[num][4]
            }
        };
        if (SmallPicsID) {
            if (this.$(SmallPicsID)) {
                var sImg = this.$(SmallPicsID).getElementsByTagName("span"),i;
                for (i = 0; i < sImg.length; i++) {
                    if (i == num || num == (i - this.Data.length)) {
                        sImg[i].className = "selected"
                    } else {
                        sImg[i].className = ""
                    }
                }
            }
        };
        if (this.onselect) {
            this.onselect()
        };
        this.adNum = num
    };
    var absPosition = function(obj, parentObj) {
        var left = obj.offsetLeft,
        top = obj.offsetTop,
        tempObj = obj;
        while (tempObj.id != document.body & tempObj.id != document.documentElement & tempObj != parentObj) {
            tempObj = tempObj.offsetParent;
            left += tempObj.offsetLeft;
            top += tempObj.offsetTop
        };
        return {
            left: left,
            top: top
        }
    };
    this.show = function() {
        this.showSum--;
        this.aImgY.style.display = 'block';
        this.aImg.style.display = 'block';
        if (isIE) {
            this.aImg.style.filter = "alpha(opacity=0)";
            this.aImg.style.filter = "alpha(opacity=" + (10 - this.showSum) * 10 + ")"
        } else {
            this.aImg.style.opacity = 0;
            this.aImg.style.opacity = (10 - this.showSum) * 0.1
        };
        if (this.showSum <= 0) {
            this.aImgY.style.display = 'none';
            this.aImg.style.zIndex = 0;
            this.aImgY = null
        } else {
            this.aImg.style.zIndex = 2;
            this.showTime = setTimeout("FocusPic.childs[" + this.ID + "].show()", 5)
        }
    };
    this.next = function() {
        var temp = this.adNum;
        temp++;
        if (temp >= this.Data.length) {
            temp = 0
        };
        this.select(temp)
    };
    this.MInStopEvent = function(ObjID) {
        if (ObjID) {
            if (this.$(ObjID)) {
                if (this.$(ObjID).attachEvent) {
                    this.$(ObjID).attachEvent("onmouseover", Function("FocusPic.childs[" + this.ID + "].TimeOutEnd()"));
                    this.$(ObjID).attachEvent("onmouseout", Function("FocusPic.childs[" + this.ID + "].TimeOutBegin()"))
                } else {
                    this.$(ObjID).addEventListener("mouseover", Function("FocusPic.childs[" + this.ID + "].TimeOutEnd()"), false);
                    this.$(ObjID).addEventListener("mouseout", Function("FocusPic.childs[" + this.ID + "].TimeOutBegin()"), false)
                }
            }
        }
    };
    this.begin = function() {
        this.MInStopEvent(TitleID);
        this.MInStopEvent(SmallPicsID);
        this.MInStopEvent(BigPicID);
        this.adNum = 0;
        var i,temp = "";
        if (BigPicID) {
            if (this.$(BigPicID)) {
                var aObj = this.$(BigPicID).getElementsByTagName("a")[0];
                aObj.style.zoom = 1;
                this.$(BigPicID).style.position = "relative";
                this.$(BigPicID).style.zoom = 1;
                this.$(BigPicID).style.overflow = "hidden";
                for (i = 0; i < this.Data.length; i++) {
                    temp += '<img src="' + this.Data[i][0] + '" id="F' + this.ID + 'BF' + i + '" style="display:' + (i == this.adNum ? 'block': 'none') + '" galleryimg="no"' + (this.width ? ' width="' + this.width + '"': '') + (this.height ? ' height="' + this.height + '"': '') + ' alt="' + this.Data[i][3] + '" />'
                };
                aObj.innerHTML = temp;
                var imgObjs = aObj.getElementsByTagName("img"),
                XY = absPosition(imgObjs[0], this.$(BigPicID));
            }
        };
        if (SmallPicsID) {
            if (this.$(SmallPicsID)) {
                temp = "";
                for (i = 0; i < this.Data.length; i++) {
/*                    temp += "<span" + (this.adNum == i ? ' class="selected"': "") + "><a href='" + this.Data[i][2] + "' target='_blank'><img src='" + this.Data[i][1] + "' onmouseover='FocusPic.childs[" + this.ID + "].select(" + i + ")' alt='" + this.Data[i][3] + "' /></a></span>"*/
                    temp += "<span" + (this.adNum == i ? ' class="selected"': "") + "><img src='" + this.Data[i][1] + "' onmouseover='FocusPic.childs[" + this.ID + "].select(" + i + ")' alt='" + this.Data[i][3] + "' /></span>"
                };
                this.$(SmallPicsID).innerHTML = temp
            }
        };
        if (TitleID) {
            if (this.$(TitleID)) {
                this.$(TitleID).innerHTML = "<a href='" + this.Data[this.adNum][2] + "' target='_blank'>" + this.Data[this.adNum][3] + "</a>"
            }
        };
        if (MemoID) {
            if (this.$(MemoID)) {
                this.$(MemoID).innerHTML = this.Data[this.adNum][4]
            }
        };
        this.TimeOutBegin()
    };
    this.$ = function(objName) {
        if (document.getElementById) {
            return eval('document.getElementById("' + objName + '")')
        } else {
            return eval('document.all.' + objName)
        }
    }
};

//2011.07.26
$(function(){
	var $div_ulli =$("div.panel ul li");
	var $div_ulli_1 =$("div.panel_box div");
	$div_ulli.mouseover(function(){
		var index =  $div_ulli.index(this);
		$("div.panel_box > div") 
			.eq(index).show() 
			.siblings().hide();
	}).mouseout(function(){
		$("div.panel_box > div").hide();
	}).hover(function(){
			$(this).addClass("hover");
		},function(){
			$(this).removeClass("hover");
		})
	$div_ulli_1.mouseover(function(){
		$(this).show(); 
	}).mouseout(function(){
		$(this).hide(); 
	})
})
$(document).ready(function(){
	$(".panel li").mouseover(function(){
			$('li').addClass('highlight_1')
			$(this).removeClass('highlight_1')
	})
});

//2011.08.16
$(function(){
	var $rss_content =$("div.top_channl .channl_a");
	$rss_content.mouseover(function(){
		$(this).addClass("selected_t")            //当前<li>元素高亮
			   .siblings().removeClass("selected_t");  //去掉其它同辈<li>元素的高亮
		var index =  $rss_content.index(this);  // 获取当前点击的<li>元素 在 全部li元素中的索引。
		$("div.channl_box > div")   	//选取子节点。不选取子节点的话，会引起错误。如果里面还有div 
				.eq(index).show()   //显示 <li>元素对应的<div>元素
				.siblings().hide(); //隐藏其它几个同辈的<div>元素
	})
})

$(function(){
	$(".w_list_box").each(function(i){
		$(this).width($(this).children("dl").length*152+76);
	});
	$(".w_nav_con>li").each(function(i){
		if(i==0) return;
		$(this).hover(
			function(){
				$(this).addClass("w_nav_sp");
				$(this).find(".w_list_box").show();
			},
			function(){
				$(this).removeClass("w_nav_sp");
				$(this).find(".w_list_box").hide();
			}
		)
	});
	tab(".w_bot_nav>li",".w_bot_box>div","w_bot_ul_sp","w_bot_con_sp");
	
	
	$(".w_mid_con>li>a>span").mouseenter(function (){

			$(this).closest("li").removeClass("w_mid_up_sp");
			$(this).closest("li").addClass("w_mid_up_sp")
		
		
	});
	
		
	$(".w_mid_con>li").mouseleave(function(){
			$(this).removeClass("w_mid_up_sp");
			//$(this).closest("li").addClass("w_mid_up_sp")
		});
	
	
	/*
		$(".w_mid_con>li>a>span").hover(

		function(){
			$(this).closest("li").removeClass("w_mid_up_sp");
			$(this).closest("li").addClass("w_mid_up_sp")
		},
		function(){
			$(this).closest("li").removeClass("w_mid_up_sp")
		}
	);
	
	*/
	

	
	function upscroll(){
		$(".w_img_w").animate({
				marginTop:"-35px"
			},600,function(){
				$(this).css("marginTop",0);
				$(this).append($(this).find("li:first"));
			}
		)
	}
	T=setInterval(upscroll,5000);
	var num=$(".w_img_src_list>a").length;
	$(".w_img_src_list").width(num*1680);
	var n3=0;
	var tt=setInterval(function(){n3++;if(n3>=num) n3=0;img_change(n3);},3800);
	$(".w_img_src").hover(
		function(){clearInterval(tt)},
		function(){tt=setInterval(function(){n3++;if(n3>=num) n3=0;img_change(n3);},3800);}
	);
	$(".w_img_num_m").hover(
		function(){clearInterval(tt)},
		function(){tt=setInterval(function(){n3++;if(n3>=num) n3=0;img_change(n3);},3800);}
	);
	$(".w_img_num>a").each(function(i){
		$(this).click(function(){
			n3=i;
			img_change(n3);
		})
	});
	function img_change(n3){
		$(".w_img_num>a").removeClass("w_spa");
		$(".w_img_num>a").eq(n3).addClass("w_spa");
		$(".w_img_src_list").stop(true,false);
		$(".w_img_src_list").animate({marginLeft:-1680*n3+"px"},800);
	};

})

function tab(nav,con,navlist,conshow){
		var tabnav=$(nav);
        var tabcontent=$(con);
        TabTagBox(tabnav,tabcontent);
        function TabTagBox(tabnav,showcontent){
            var tabnav=tabnav;
            var tabcontent=showcontent;
            tabnav.each(function(i){
                $(this).mouseover(function(){
                    TabTag(i);
                    })
            })
            function TabTag(index){
            tabnav.removeClass(navlist);
            tabnav.eq(index).addClass(navlist);
            tabcontent.removeClass(conshow);
            tabcontent.eq(index).addClass(conshow);
            }            
        }
}

