using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsDataGridStyleENEx : clsDataGridStyleEN
    {
        public clsDataGridStyleENEx(clsDataGridStyleEN objDataGridStyleEN)
        {
            this.DgStyleId = objDataGridStyleEN.DgStyleId; //DG模式ID
            this.DgStyleName = objDataGridStyleEN.DgStyleName; //DG模式名
            this.Runat = objDataGridStyleEN.Runat; //运行在
            this.FontSize = objDataGridStyleEN.FontSize; //字号
            this.FontName = objDataGridStyleEN.FontName; //字体
            this.AllowPaging = objDataGridStyleEN.AllowPaging; //允许分页
            this.PageSize = objDataGridStyleEN.PageSize; //页大小
            this.AutoGenerateColumns = objDataGridStyleEN.AutoGenerateColumns; //自动生成列
            this.AllowSorting = objDataGridStyleEN.AllowSorting; //允许排序
            this.IsRadio = objDataGridStyleEN.IsRadio; //是否单选框
            this.IsCheck = objDataGridStyleEN.IsCheck; //是否复选框
            this.IsJumpPage = objDataGridStyleEN.IsJumpPage; //是否跳页
            this.IsHaveUpdBtn = objDataGridStyleEN.IsHaveUpdBtn; //是否有修改按钮
            this.IsHaveDelBtn = objDataGridStyleEN.IsHaveDelBtn; //是否有删除按钮
            this.IsHaveDetailBtn = objDataGridStyleEN.IsHaveDetailBtn; //是否有详细按钮
            this.IsInTab = objDataGridStyleEN.IsInTab; //是否生成DG在表中
            this.StyleZindex = objDataGridStyleEN.StyleZindex; //StyleZindex
            this.StyleLeft = objDataGridStyleEN.StyleLeft; //StyleLeft
            this.StylePosition = objDataGridStyleEN.StylePosition; //StylePosition
            this.Width = objDataGridStyleEN.Width; //宽
            this.Height = objDataGridStyleEN.Height; //高度
            this.StyleTop = objDataGridStyleEN.StyleTop; //StyleTop
            this.Style = objDataGridStyleEN.Style; //类型
            this.IsDefault = objDataGridStyleEN.IsDefault; //是否默认

        }
    }
}
