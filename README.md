# Intercept-netkeeper-account

------

控制台应用程序：Intercept-netkeeper-account 项目概述

## 一、作者描述

> 本程序用于截取NetKeeper拨号时的真实账号，截获到的账号可以用于路由器、电脑等的pppoe拨号。原理是NetKeeper在拨号时会在系统日志中添加一条包含账号的事件，然后再全部清空应用事件日志，所以我编写了这个程序来监控事件日志的变动，并及时的获取日志信息，再截取重要的账号部分。

------
## 二、使用帮助

### 如何截获账号
    1.使用管理员权限打开.exe文件或者.ps1文件
    2. 使用.exe文件时，在控制台输入1，然后使用netkeeper拨号即可
    3. 使用.ps1文件时，直接使用最新版的powershell运行文件，然后使用netkeeper拨号即可

### 截获账号之后
    1. 选择一款可以给路由器拨号的软件，或者直接使用宽带拨号器
    2. 在拨号软件框输入“\r”再复制截获到的账号到输入框，（一定要是“\r”+"你的账号"，例如：“\r5s2v5de5d5702114051@ndcard”）

-------
## 三、VS2015描述

    应用程序向导已为您创建了此 Intercept-netkeeper-account 应用程序。
    本文件概要介绍组成 Intercept-netkeeper-account 应用程序的每个文件的内容。
    Intercept-netkeeper-account.vcxproj
        这是使用应用程序向导生成的 VC++ 项目的主项目文件，其中包含生成该文件的 Visual C++ 的版本信息，以及有关使用应用程序向导选择的平台、配置和项目功能的信息。
    Intercept-netkeeper-account.vcxproj.filters
        这是使用“应用程序向导”生成的 VC++ 项目筛选器文件。它包含有关项目文件与筛选器之间的关联信息。在 IDE 中，通过这种关联，在特定节点下以分组形式显示具有相似扩展名的文件。例如，“.cpp”文件与“源文件”筛选器关联。
    Intercept-netkeeper-account.cpp
        这是主应用程序源文件。
    其他标准文件:
    StdAfx.h, StdAfx.cpp
        这些文件用于生成名为 Intercept-netkeeper-account.pch 的预编译头 (PCH) 文件和名为 StdAfx.obj 的预编译类型文件。
    其他注释:
    应用程序向导使用“TODO:”注释来指示应添加或自定义的源代码部分。
