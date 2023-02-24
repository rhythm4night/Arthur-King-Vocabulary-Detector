# 亚瑟 King 取词器 V 1.2
一个简单的英语生词提取程序 使用 Visual Studio C# 编写

Windows 自带防护软件报毒 是因为这是野鸡软件没有签名 请关闭防护后再食用

![001](https://user-images.githubusercontent.com/126004179/220474379-0755871a-fe19-4b04-a4f7-3a81efb5990d.png)

A simple program for extracting possible vocabulary from text

Some security software reports the virus because it is pheasant software without signature


## 如何使用 How To Use


###  STEP 1

把你想要识别的字幕文件拖入 ‘input’ 文件夹（TXT、SRT...）

Please drag thefile into the 'input' folder first （TXT、SRT...）


![01](https://user-images.githubusercontent.com/126004179/220475957-7245b888-2b12-4b93-b9aa-e6715f7855f9.gif)


###  STEP 2

准备好想要过滤的单词，拖入 ‘known’ 文件夹（已经提供一些预设）

Please put the filtered word file into the 'input' folder

![02](https://user-images.githubusercontent.com/126004179/220477524-a2717f45-f3f8-4728-9618-a21dbb0959cc.gif)



###  STEP 3
运行程序，去 ‘output’ 文件夹查看生词

Run the program , Go to the 'output' folder to see the results

![03](https://user-images.githubusercontent.com/126004179/220483365-960246de-46e5-4654-83d0-32656f9cca16.gif)

你可以选择把生成的文件直接转手扔进‘known’ 文件夹，避免以后重复识别

You can choose to just dump these files directly into the 'known' folder

###  STEP 4
前往词汇网站 ‘www.vocabulary.com’ 轻松创建List

Go to the glossary website 'www.vocabulary.com' to easily create a List

![04](https://user-images.githubusercontent.com/126004179/220484012-12422793-5ae1-4139-b64e-239d81975a89.gif)

## 介绍视频 Introduction Video

[![Introduction Video](https://res.cloudinary.com/marcomontalbano/image/upload/v1677080244/video_to_markdown/images/youtube---vO__prPsH4-c05b58ac6eb4c4700831b2b3070cd403.jpg)](https://www.youtube.com/watch?v=-vO__prPsH4 "Introduction Video")

## 其他下载途径 Downloads

考虑到github有时可能访问速度较差，这是一些其他下载链接：

https://www.mediafire.com/file/14wd5gzgcy39dli/King.Ver.1.2.x64.7z/file

https://www.mediafire.com/file/gokfhibju29fczs/King.Ver.1.2.x86.7z/file


## 引用的库
NHunspell https://www.nuget.org/packages/NHunspell/

Hunspell.Native https://www.nuget.org/packages/Hunspell.Native/

用于进行拼写检查和单词原型处理

For spell checking and word prototyping

