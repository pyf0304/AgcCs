# 批量添加 ReplaceField 函数的 PowerShell 脚本
# 保存为 Add-ReplaceFieldFunctions.ps1

$basePath = "E:\AspNet2024\AgcCs\AgcBLLEx\Class"

# 定义所有需要添加的类和对应的表名
$classes = @(
    @{Class="clsButtonTabBLEx"; Path="PrjFunction\clsButtonTabBLEx.cs"; Table="ButtonTab"},
    @{Class="clsCMFeatureBLEx"; Path="CodeMan\clsCMFeatureBLEx.cs"; Table="CMFeature"},
    @{Class="clsCodeTypeBLEx"; Path="GeneCode\clsCodeTypeBLEx.cs"; Table="CodeType"},
    @{Class="clsConstraintFieldsBLEx"; Path="Table_Field\clsConstraintFieldsBLEx.cs"; Table="ConstraintFields"},
    @{Class="clsConstraintTypeBLEx"; Path="Table_Field\clsConstraintTypeBLEx.cs"; Table="ConstraintType"},
    @{Class="clsCtlTypeBLEx"; Path="PrjInterface\clsCtlTypeBLEx.cs"; Table="CtlType"},
    @{Class="clsDetailRegionFldsBLEx"; Path="RegionManage\clsDetailRegionFldsBLEx.cs"; Table="DetailRegionFlds"},
    @{Class="clsDGRegionFldsBLEx"; Path="RegionManage\clsDGRegionFldsBLEx.cs"; Table="DGRegionFlds"},
    @{Class="clsDNPathBLEx"; Path="AIModule\clsDNPathBLEx.cs"; Table="DnPath"},
    @{Class="clsExcelExportRegionFldsBLEx"; Path="RegionManage\clsExcelExportRegionFldsBLEx.cs"; Table="ExcelExportRegionFlds"},
    @{Class="clsPrjConstraintBLEx"; Path="Table_Field\clsPrjConstraintBLEx.cs"; Table="PrjConstraint"},
    @{Class="clsPrjFeatureBLEx"; Path="PrjFunction\clsPrjFeatureBLEx.cs"; Table="PrjFeature"},
    @{Class="clsQryRegionFldsBLEx"; Path="RegionManage\clsQryRegionFldsBLEx.cs"; Table="QryRegionFlds"},
    @{Class="clsTabFeatureBLEx"; Path="Table_Field\clsTabFeatureBLEx.cs"; Table="TabFeature"},
    @{Class="clsTabFeatureFldsBLEx"; Path="Table_Field\clsTabFeatureFldsBLEx.cs"; Table="TabFeatureFlds"},
    @{Class="clsCacheModeBLEx_Static"; Path="SystemSet\clsCacheModeBLEx.cs"; Table="CacheMode"},
    @{Class="clsCollegeBLEx_Static"; Path="BaseInfo\clsCollegeBLEx.cs"; Table="College"}
)

# ReplaceField 函数模板
$functionTemplate = @'

        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static bool ReplaceField(string strPrjId, string strSourceFldId, string strTargetFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            strSQL = string.Format("Update {0} Set FldId = '{{0}}' where PrjId = '{{1}}' And FldId = '{{2}}'",
                                                strTargetFldId, strPrjId, strSourceFldId);
            return objSQL.ExecSql(strSQL);
        }
'@

function Add-ReplaceFieldFunction {
    param(
        [string]$FilePath,
        [string]$TableName,
        [string]$ClassName
    )

    if (-not (Test-Path $FilePath)) {
        Write-Host "❌ 文件不存在: $FilePath" -ForegroundColor Red
        return $false
    }

    $content = Get-Content $FilePath -Raw -Encoding UTF8

    # 检查是否已经存在 ReplaceField 函数
    if ($content -match "public static bool ReplaceField\(string strPrjId") {
        Write-Host "⚠️  已存在 ReplaceField 函数: $ClassName" -ForegroundColor Yellow
        return $false
    }

    # 生成特定于该表的函数
    $function = $functionTemplate -replace '\{0\}', $TableName

    # 找到最后一个闭合大括号的位置（类的结束）
    $lastBraceIndex = $content.LastIndexOf('}')

    if ($lastBraceIndex -gt 0) {
        # 在最后一个大括号之前插入函数
        $newContent = $content.Substring(0, $lastBraceIndex) + $function + "`r`n    }`r`n}"

        # 备份原文件
        $backupPath = $FilePath + ".backup_" + (Get-Date -Format "yyyyMMddHHmmss")
        Copy-Item $FilePath $backupPath -Force

        # 写入新内容
        [System.IO.File]::WriteAllText($FilePath, $newContent, [System.Text.Encoding]::UTF8)

        Write-Host "✅ 成功添加到: $ClassName" -ForegroundColor Green
        return $true
    } else {
        Write-Host "❌ 无法找到类结束位置: $ClassName" -ForegroundColor Red
        return $false
    }
}

# 统计信息
$successCount = 0
$failCount = 0
$skipCount = 0

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "开始批量添加 ReplaceField 函数" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# 处理所有类
foreach ($class in $classes) {
    $fullPath = Join-Path $basePath $class.Path
    Write-Host "处理: $($class.Class)..." -NoNewline

    $result = Add-ReplaceFieldFunction -FilePath $fullPath -TableName $class.Table -ClassName $class.Class

    if ($result -eq $true) {
        $successCount++
        Write-Host ""
    } elseif ((Test-Path $fullPath) -and (Get-Content $fullPath -Raw) -match "ReplaceField") {
        $skipCount++
        Write-Host ""
    } else {
        $failCount++
        Write-Host ""
    }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "处理完成！" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "✅ 成功: $successCount 个" -ForegroundColor Green
Write-Host "⚠️  跳过: $skipCount 个" -ForegroundColor Yellow
Write-Host "❌ 失败: $failCount 个" -ForegroundColor Red
Write-Host ""
Write-Host "💾 备份文件已创建 (*.backup_yyyyMMddHHmmss)" -ForegroundColor Cyan
Write-Host ""
Write-Host "⚠️  请在 Visual Studio 中重新加载修改的文件！" -ForegroundColor Yellow