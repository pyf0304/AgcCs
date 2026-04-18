using System;
using System.Collections.Generic;

namespace AGC.Entity
{
   
    /// <summary>
    /// 执行复制任务结果
    /// </summary>
    [Serializable]
    public class ExecuteCopyTaskResultDto
    {
        public int errorId { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public string targetViewId { get; set; }
        public string targetViewName { get; set; }
        public int totalRegions { get; set; }
        public int completedRegions { get; set; }
        public int failedRegions { get; set; }
        public List<CopyRegionStatusDto> regionStatuses { get; set; }

        public ExecuteCopyTaskResultDto()
        {
            success = false;
            message = "";
            targetViewId = "";
            targetViewName = "";
            totalRegions = 0;
            completedRegions = 0;
            failedRegions = 0;
            regionStatuses = new List<CopyRegionStatusDto>();
        }
    }

    
}