<!DOCTYPE html>
<html lang = "en" >

< head >
    < meta charset="UTF-8">
    <!-- <meta name = "viewport" content="width=device-width, initial-scale=1.0"> -->
  <meta name = "viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

    <title>Document</title>
    <script>
        function speckText()
{
    var str = document.getElementById("text1").value
            console.log(str)
            var url = "http://tts.baidu.com/text2audio?lan=zh&ie=UTF-8&text=" + encodeURI(str);  //将str进行编码
    var n = new Audio(url);
    n.src = url;
    n.play();
}
function shuru()
{
    var text = document.getElementById("text1")
            text.placeholder = ""
        }
function clean()
{
    // var clean=document.getElementById("clean")
    document.getElementById("text1").value = ""

        }
    </script>
    <style>
        .contain{
            background-color: bisque;
            margin: 100px auto;
height: 130px;
            display: flex;
            width: 380px;
            flex-direction: column;
            align-items: center;
            border-radius: 15px;
            box-shadow: 15px 15px 15px darkgray;
        }
        .container{
            width: 100%;
            text-align: center;
            /* border: 1px solid black; */
        }
        span{
            display: inline-block;
            width: 20px;
            height: 20px;
            border: 1.5px solid gray;
            border-radius: 50%;
            background: #ffffff;
        }
        input{
            text-align: center;
            height: 30px;
            width: 80%;
            font-size: 17px;
            margin-top: 20px;
            border-radius: 5px;
        }
        button{
            font-size: 17px;
            margin-top: 20px;
            border-radius: 5px;


        }
    </style>
</head>

<body>
    <div class="contain">  
        <div class="container">
            <input type = "text" onclick="shuru()" id="text1" placeholder="请输入要播放的内容">
            <span id = "x" onclick="clean()">X</span>
        </div>
    <div><button onclick = "speckText()" > 语音播放 </ button ></ div >
    </ div >
</ body >

</ html >
