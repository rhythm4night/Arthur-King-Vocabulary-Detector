# 亚瑟 King 取词器 V 1.2
A simple program for extracting possible vocabulary from text

![001](https://user-images.githubusercontent.com/126004179/220474379-0755871a-fe19-4b04-a4f7-3a81efb5990d.png)

一个简单的英语生词提取程序 使用 Visual Studio C# 编写

Windows 自带防护软件报毒 是因为这是野鸡软件没有签名 请关闭防护后再食用


Some security software reports the virus because it is pheasant software without signature


## 如何使用 How To Use


###  STEP 1

以STR字幕为例，请先把文件名后缀改为TXT，然后拖入 ‘input’ 文件夹

Take STR subtitles as an example, please change the file name suffix to TXT and then drag it into the 'input' folder

![01](https://user-images.githubusercontent.com/126004179/220475957-7245b888-2b12-4b93-b9aa-e6715f7855f9.gif)


###  STEP 2

准备好想要过滤的单词，拖入 ‘known’ 文件夹（已经提供一些预设）

Prepare the words you want to filter by dragging them into the 'known' folder (some presets are already provided)

![02](https://user-images.githubusercontent.com/126004179/220477524-a2717f45-f3f8-4728-9618-a21dbb0959cc.gif)



###  STEP 3
运行程序，去 ‘outpot’ 文件夹查看生词

Run the program , go to the 'outpot' folder to see the raw words

![03](https://user-images.githubusercontent.com/126004179/220483365-960246de-46e5-4654-83d0-32656f9cca16.gif)

###  STEP 4
前往词汇网站 ‘www.vocabulary.com’ 轻松创建List

Go to the glossary website 'www.vocabulary.com' to easily create a List

![04](https://user-images.githubusercontent.com/126004179/220484012-12422793-5ae1-4139-b64e-239d81975a89.gif)

## 引用的库
NHunspell https://www.nuget.org/packages/NHunspell/
Hunspell.Native https://www.nuget.org/packages/Hunspell.Native/

用于进行拼写检查和单词原型处理

For spell checking and word prototyping

