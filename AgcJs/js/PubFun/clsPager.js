/*
 * 功能：用于分页的功能函数
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    /// <reference path="../../../wwwroot/typings/jquery/jquery.d.ts" />
    var clsPager = /** @class */ (function () {
        function clsPager() {
            this.mintPageIndex = 1;
            this.mintPageCount = 0;
            /// <summary>
            /// 专门用于记录GridView中的每页记录数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenPageSizeViewState)
            /// </summary>
            this.PageSize = 15;
            /// <summary>
            /// 设置GridView中的总页数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_RecCount)
            /// </summary>
            this.RecCount = 0;
        }
        Object.defineProperty(clsPager.prototype, "PageIndex", {
            /// <summary>
            /// 设置GridView中的页序号
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageIndex)
            /// </summary>
            get: function () {
                return this.mintPageIndex;
            },
            set: function (value) {
                this.mintPageIndex = value;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsPager.prototype, "PageCount", {
            /// <summary>
            /// 设置GridView中的总页数
            /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:Gen_PageCount)
            /// </summary>
            get: function () {
                return this.mintPageCount;
            },
            set: function (value) {
                this.mintPageCount = value;
            },
            enumerable: true,
            configurable: true
        });
        /// <summary>
        /// 函数功能:计算当前页数，根据记录数和每页记录数
        /// (AutoGCLib.WebCtlControlCode4Gv4CSharp:GenGetPageCount)
        /// </summary>
        /// <param name = "intRecCount">总记录数</param>
        /// <param name = "intPageSize">每页记录数</param>
        clsPager.prototype.GetPageCount = function (intRecCount, intPageSize) {
            if (intRecCount == 0)
                return 0;
            var intPageCount = Math.ceil(intRecCount / intPageSize);
            if (intRecCount % intPageSize == 0)
                return intPageCount;
            return intPageCount;
        };
        clsPager.prototype.IndexPage = function (intPageIndex) {
            this.PageIndex = intPageIndex;
            $('#hidCurrPageIndex').val(intPageIndex);
            this.ShowPager();
        };
        clsPager.prototype.PageNum = function (intPageIndex) {
            this.PageIndex = intPageIndex;
            $('#hidCurrPageIndex').val(intPageIndex);
            this.ShowPager();
        };
        clsPager.prototype.jumpToPage = function (intPageIndex) {
            this.PageIndex = intPageIndex;
            $('#hidCurrPageIndex').val(intPageIndex);
            this.ShowPager();
        };
        clsPager.prototype.ShowPager = function () {
            //var padingnum = 100;
            $('#projectlist').find("li").remove();
            //<br>　　　　　　//开始是分页的核心了
            if (this.RecCount > 0) {
                //设置页码
                //     var pading =  data[0].padingnum;//总页码
                this.PageCount = this.GetPageCount(this.RecCount, this.PageSize);
                $('#totalpage').val(this.PageCount);
                var page = $('#hidCurrPageIndex').val(); //当前页
                $('#spnCountPage').html("第<b id='currentPageNo'> " + page + "</b>页 ");
                //$('#spnNumber').html("共"+this.PageCount+"页 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='IndexPage(-2)' /goods/ajaxqueryGoodsList.do.html','','goodsListContainer','"+pading+"', listPageCallback);' class='page-btn'/>")
                $('#spnNumber').html("共" + this.PageCount + "页 共" + this.RecCount + "记录 到第<input type='text' id='input_number' class='page-txtbox' />页<input name='' value='确定' type='button' onclick='JumpToPage()' class='page-btn' />");
            }
            else {
                $('#spnCountPage').html("<b id='currentPageNo'>" + 0 + "</b>");
            }
            //设置分页的底部 就是 首页  1   2   3   4   5   6   尾页
            this.PageCount = this.GetPageCount(this.RecCount, this.PageSize); //总页码href="javascript:void(0);"
            this.PageIndex = Number($('#hidCurrPageIndex').val()); //当前页
            //one  two  three five fore<br>　　　　　　//下面代码看着是比较麻烦，但是也不难理解  全是一样的代码，只不过是加了些判断
            if (this.PageIndex < 5) {
                $('#one').text("1");
                $('#one').attr('href', 'javascript:PageNum("' + 1 + '");');
                $('#two').text("2");
                $('#two').attr('href', 'javascript:PageNum("' + (2) + '");');
                $('#three').text("3");
                $('#three').attr('href', 'javascript:PageNum("' + (3) + '");');
                $('#five').text("4");
                $('#five').attr('href', 'javascript:PageNum("' + (4) + '");');
                $('#fore').text("5");
                $('#fore').attr('href', 'javascript:PageNum("' + (5) + '");');
                this.ShowLi('#five');
                this.ShowLi('#fore');
            }
            else {
                //alert("已经不是第五页了");
                //设置中间的为当前页
                $('#one').text((this.PageIndex - 2).toString());
                $('#one').attr('href', 'javascript:IndexPage("' + (this.PageIndex - 2) + '");');
                $('#two').text(this.PageIndex - 1);
                $('#two').attr('href', 'javascript:IndexPage("' + (this.PageIndex - 1) + '");');
                $('#three').text(this.PageIndex.toString());
                $('#three').attr('href', 'javascript:IndexPage("' + (this.PageIndex) + '");');
                this.ShowLi('#five');
                this.ShowLi('#fore');
                //判断下一页是否超过了总页数
                if (this.PageIndex + 1 > this.PageCount) {
                    this.HideLi('#five');
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('#fore');
                }
                else {
                    this.ShowLi('#five');
                    $('#five').text(this.PageIndex + 1);
                    $('#five').attr('href', 'javascript:IndexPage("' + (this.PageIndex + 1) + '");');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.PageIndex + 2 > this.PageCount) {
                    this.HideLi('#fore');
                }
                else {
                    this.ShowLi('#fore');
                    $('#fore').text(this.PageIndex + 2);
                    $('#fore').attr('href', 'javascript:IndexPage("' + (this.PageIndex + 2) + '");');
                }
            }
            //如果总页数小于5，这块代码主要就是设置  1  2  3  4  5  这些的显示和隐藏的
            if (this.PageCount == 0) {
                this.HideLi('#one');
                this.HideLi('#two');
                this.HideLi('#three');
                this.HideLi('#five');
                this.HideLi('#fore');
            }
            else if (this.PageCount == 1) {
                $('#liFirstPage').hide();
                $('#liLastPage').hide();
                this.HideLi('#one');
                this.HideLi('#two');
                this.HideLi('#three');
                this.HideLi('#five');
                this.HideLi('#fore');
            }
            else if (this.PageCount == 2) {
                this.ShowLi('#one');
                this.ShowLi('#two');
                this.HideLi('#three');
                this.HideLi('#five');
                this.HideLi('#fore');
            }
            else if (this.PageCount == 3) {
                this.ShowLi('#one');
                this.ShowLi('#two');
                this.ShowLi('#three');
                this.HideLi('#five');
                this.HideLi('#fore');
            }
            else if (this.PageCount == 4) {
                this.ShowLi('#one');
                this.ShowLi('#two');
                this.ShowLi('#three');
                this.ShowLi('#five');
                this.HideLi('#fore');
            }
            else {
                if (this.PageIndex <= this.PageCount) {
                    this.ShowLi('#one');
                    this.ShowLi('#two');
                    this.ShowLi('#three');
                    this.ShowLi('#five');
                    this.ShowLi('#fore');
                }
                //判断下一页是否超过了总页数
                if (this.PageIndex + 1 > this.PageCount) {
                    this.HideLi('#five');
                    //var liFive: HTMLLIElement = $('#five').parent() as HTMLLIElement;
                    //liFive.hidden = true;
                    this.HideLi('#fore');
                }
                else {
                    this.ShowLi('#five');
                }
                //判断下一页的第二页是否超过了总页数
                if (this.PageIndex + 2 > this.PageCount) {
                    this.HideLi('#fore');
                }
                else {
                    this.ShowLi('#fore');
                }
            }
            if (this.PageIndex + 1 > this.PageCount) {
                $('#btnNextPage').addClass('disabled');
                $('#btnLastPage').addClass('disabled');
            }
            else {
                $('#btnNextPage').removeClass('disabled');
                $('#btnLastPage').removeClass('disabled');
            }
            if (this.PageIndex == 1) {
                $('#btnPrevPage').addClass('disabled');
                $('#btnFirstPage').addClass('disabled');
            }
            else {
                $('#btnPrevPage').removeClass('disabled');
                $('#btnFirstPage').removeClass('disabled');
            }
            this.SetCurrPageStatus(this.PageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            //分页完返回页面顶端
            $("html,body").animate({ scrollTop: 0 }, 500);
            //最后，给当前页码加1
            $('#hidCurrPageIndex').val(this.PageIndex);
        };
        /*
       *设置当前页的状态，当前页，显示特殊颜色
       */
        clsPager.prototype.SetCurrPageStatus = function (intPageIndex) {
            console.log('SetCurrPageStatus:');
            console.log(intPageIndex);
            //设置高亮显示的，就是是第一页时，1亮，第二页时  2亮
            $('#page a').each(function () {
                var evt = this; // window.event || arguments[0];
                var LinkA = evt;
                if (LinkA == null)
                    return;
                var lnkParent = LinkA.parentNode;
                if (lnkParent == null)
                    return;
                //            console.log(lnkParent);
                LinkA.classList.remove("btn-outline-warning");
                LinkA.classList.remove("btn-outline-info"); //btn btn - outline - info btn - sm
                if (Number(LinkA.innerText) == intPageIndex) {
                    //lnkParent.classList.add("btn-info");
                    LinkA.classList.add("btn-outline-warning");
                }
                else {
                    //lnkParent.classList.add("btn-outline-info");
                    LinkA.classList.add("btn-outline-info");
                }
                //console.log(lnkParent);
                //console.log(LinkA.innerText);
            });
        };
        clsPager.prototype.HideLi = function (strAnchor) {
            var thisLi = $(strAnchor).parent();
            thisLi.hide();
            //thisLi.css("visibility", "hidden");
            thisLi.css("display", "none");
            //console.log(strAnchor);
            //console.log(thisLi);
        };
        clsPager.prototype.ShowLi = function (strAnchor) {
            var thisLi = $(strAnchor).parent();
            thisLi.show();
            //thisLi.css("visibility", "visible");
            thisLi.css("display", "block");
            //console.log(strAnchor);
            //console.log(thisLi);
        };
        return clsPager;
    }());
    exports.clsPager = clsPager;
});
