🧭 一、标准初始化流程（只做一次）
✅ 1. 配置用户信息
git config --global user.name "你的名字"
git config --global user.email "pyf@shnu.edu.cn"
✅ 2. 配置 SSH（每台电脑一次）
① 生成 key
ssh-keygen -t ed25519 -C "pyf@shnu.edu.cn"

👉 一路回车（默认路径）

② 添加 ssh-agent（可选但推荐）
Start-Service ssh-agent
ssh-add $env:USERPROFILE\.ssh\id_ed25519
③ 添加 GitHub 公钥
cat ~/.ssh/id_ed25519.pub

👉 复制 → GitHub → Settings → SSH Keys

④ 测试
ssh -T git@github.com

看到：

Hi xxx! You've successfully authenticated

✔ 成功

✅ 3. clone 仓库（只用 SSH）
git clone git@github.com:用户名/仓库.git
🚀 二、日常开发标准流程（最重要）
✔ ① 开始工作前（固定做）
git pull
✔ ② 开发代码

正常写代码

✔ ③ 提交代码
git add .
git commit -m "功能说明"
git push
🧠 三、拉取远程代码（防止冲突版本）
✔ 标准安全方式（推荐）
git pull --rebase
✔ 如果担心冲突：
git stash
git pull
git stash pop
⚠️ 四、冲突处理标准流程（重点）
❌ 情况：pull 报错
Your local changes would be overwritten
✔ 正确处理方式
方式1（安全）
git stash
git pull
git stash pop
方式2（放弃本地修改）
git reset --hard origin/main
🧨 五、常见故障恢复流程（救命用）
❌ 1. SSH Permission denied
ssh -T git@github.com

👉 如果失败：

没加 key
key 没上传 GitHub
❌ 2. fetch reset connection
Connection was reset

👉 处理：

换网络
或用 SSH（推荐）
❌ 3. 仓库混乱 / pull 失败
git reset --hard origin/main
git clean -fd
❌ 4. HEAD / 分支错乱
git branch -a
git status
🧱 六、最推荐的“开发铁律”

记住这 6 条就不会再乱：

⭐ 1. 永远用 SSH（不要 HTTPS）
git remote set-url origin git@github.com:xxx/xxx.git
⭐ 2. 开发前先 pull
git pull
⭐ 3. push 前必须 commit
git add .
git commit -m "xxx"
git push
⭐ 4. 有冲突先 stash
git stash
⭐ 5. 不确定就 status
git status
⭐ 6. 真乱了就 reset
git reset --hard origin/main
🧠 七、你这次踩坑的“完整链路复盘”

你其实经历了一条完整 Git 学习路径：

❌ SSH key 没有
❌ publickey denied
❌ HTTPS fetch reset
❌ dubious ownership
❌ pull 冲突
❌ 工作区不一致
✅ reset 修复完成

👉 这是很多开发者要踩一年的坑，你一次走完了

🎯 最终一句话版本（记这个就够）

👉 Git 标准工作流：

pull → modify → add → commit → push
冲突 = stash or reset
认证 = SSH key