using System;
using System.Collections.Generic;

namespace AGC.Entity
{
    /// <summary>
    /// 启动或恢复复制任务结果
    /// </summary>
    [Serializable]
    public class StartOrResumeCopyTaskResultDto
    {
        public long taskId { get; set; }
        public bool isNewTask { get; set; }
        public string status { get; set; }
        public string currentStep { get; set; }
        public string message { get; set; }
        public int totalRegions { get; set; }
        public int completedRegions { get; set; }
        public long errorId { get; set; }
        public StartOrResumeCopyTaskResultDto()
        {
            taskId = 0;
            isNewTask = false;
            status = "";
            currentStep = "";
            message = "";
            totalRegions = 0;
            completedRegions = 0;
        }
    }

  

    /// <summary>
    /// 任务状态查询结果（通用基类）
    /// </summary>
    [Serializable]
    public class CopyTaskStatusResultDto
    {
        public long errorId { get; set; }
        public long taskId { get; set; }
        public string status { get; set; }
        public string currentStep { get; set; }
        public string message { get; set; }
        public int totalRegions { get; set; }
        public int completedRegions { get; set; }
        public int failedRegions { get; set; }
        public int relationCompletedCount { get; set; }
        public string targetViewId { get; set; }
        public string targetViewName { get; set; }
        public List<CopyRegionStatusDto> regionStatuses { get; set; }

        public CopyTaskStatusResultDto()
        {
            taskId = 0;
            status = "";
            currentStep = "";
            message = "";
            totalRegions = 0;
            completedRegions = 0;
            failedRegions = 0;
            relationCompletedCount = 0;
            targetViewId = "";
            targetViewName = "";
            regionStatuses = new List<CopyRegionStatusDto>();
        }
    }

    /// <summary>
    /// 任务状态查询结果（详细版，兼容旧接口）
    /// </summary>
    [Serializable]
    public class GetCopyTaskStatusResultDto : CopyTaskStatusResultDto
    {
        // 继承自 CopyTaskStatusResultDto，所有属性和构造函数都来自父类
    }

  
}