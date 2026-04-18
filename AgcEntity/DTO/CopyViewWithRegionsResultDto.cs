using System;
using System.Collections.Generic;

namespace AGC.Entity
{
    /// <summary>
    /// 复制界面（带区域）返回结果
    /// </summary>
    [Serializable]
    public class CopyViewWithRegionsResultDto
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string targetViewId { get; set; }
        public string targetViewName { get; set; }
        public List<CopyRegionStatusDto> regionStatuses { get; set; }
        public long taskId { get; set; }  // 新增任务ID

        public CopyViewWithRegionsResultDto()
        {
            message = "";
            targetViewId = "";
            targetViewName = "";
            regionStatuses = new List<CopyRegionStatusDto>();
            taskId = 0;
        }
    }

    /// <summary>
    /// 区域复制状态
    /// </summary>
    [Serializable]
    public class CopyRegionStatusDto
    {
        public string sourceRegionId { get; set; }
        public string clsName { get; set; }
        public string targetRegionId { get; set; }
        public string copyStatus { get; set; }      // Pending/Success/Failed/Reused/Skipped
        public string relationStatus { get; set; }  // Pending/Success/Failed/Reused/Skipped
        public string errorMessage { get; set; }    // 错误信息

        public CopyRegionStatusDto()
        {
            sourceRegionId = "";
            clsName = "";
            targetRegionId = "";
            copyStatus = "Pending";
            relationStatus = "Pending";
            errorMessage = "";
        }
    }
}