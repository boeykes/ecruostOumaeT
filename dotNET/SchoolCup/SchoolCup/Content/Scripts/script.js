window.addEventListener("load",init,false);

var advertismentObjects = new Array;
var logos = new Array();
var i = 0;



function init(){
    logos = document.getElementsByClassName('ads');
    for(var i = 0; i<logos.length; i++){
        advertismentObjects[i] = new Advertisements(logos[i]);
        logos[i].style.top = 100 + "px";
        logos[i].style.left = 960 + "px";
    }

    loopAds();
    if(logos.length > 2){
        setInterval(loopAds,10000);
    }else if(logos.length > 1){
        setInterval(loopAds,20000);
    }else{
        setInterval(loopAds,30000);
    }
}

function Advertisements(logo){
    this.timer = null;
    this.timerTwee = null;
    this.timerDrie = null;
    this.aantalPixelsLeft = 960;
    this.aantalPixelsTop = 50;
    this.arcGemaakt = false;
    this.rotationAngle = 0;
    this.omhoog = true;
    this.logo = logo;
}

function loopAds(){
    var adv = advertismentObjects[i%advertismentObjects.length];
    initAdvertisementObject(adv);
    moveImage(adv);
    i++;
}

function initAdvertisementObject(adv){
    clearInterval(adv.timer);
    clearInterval(adv.timerTwee);
    clearInterval(adv.timerDrie);
    adv.timer = null;
    adv.timerTwee = null;
    adv.timerDrie = null;
    adv.aantalPixelsLeft = 960;
    adv.aantalPixelsTop = 100;
    adv.arcGemaakt = false;
    adv.rotationAngle = 0;
    adv.omhoog =true;
}

function moveImage(adv){
    adv.logo.style.top = adv.aantalPixelsTop + "px";
    adv.logo.style.left = adv.aantalPixelsLeft + "px";

    adv.timer = setInterval(function() { moveLeft(adv); }, 25);
}

function moveLeft(adv){
    if(adv.aantalPixelsLeft <= -250){
        clearInterval(adv.timer);
    }
    if(adv.aantalPixelsLeft <= 820 && !adv.arcGemaakt){
        adv.timerTwee = setInterval(function() { makeArc(adv); },25);
        clearInterval(adv.timer);
    }
    if(adv.rotationAngle != 0){
        adv.rotationAngle++;
        adv.logo.style.transform = "rotate("+adv.rotationAngle+"deg)";
        adv.logo.style.webkitTransform = "rotate("+adv.rotationAngle+"deg)";
    }

    adv.logo.style.left = adv.aantalPixelsLeft + "px";
    adv.aantalPixelsLeft--;
}

function makeArc(adv){
    if(adv.aantalPixelsTop <= 51){
        adv.omhoog = false;
    }
    if(adv.omhoog){
        adv.aantalPixelsTop--;
        adv.aantalPixelsLeft-=3;
        if(adv.rotationAngle < 10){
            adv.rotationAngle++;
        }
    }else if(adv.aantalPixelsTop <= 175){
        adv.aantalPixelsTop+=2;
        adv.aantalPixelsLeft-=1,5;
        if(adv.rotationAngle >-10){
            adv.rotationAngle -= 2;
        }
    }else{
        adv.arcGemaakt = true;
        adv.omhoog = true;
        adv.timer = setInterval(function() { moveLeft(adv); }, 25);
        adv.timerDrie = setInterval(function() { doSwimming(adv); }, 100);
        clearInterval(adv.timerTwee);
    }

    adv.logo.style.transform = "rotate("+adv.rotationAngle+"deg)";
    adv.logo.style.webkitTransform = "rotate("+adv.rotationAngle+"deg)";
    adv.logo.style.top = adv.aantalPixelsTop + "px";
    adv.logo.style.left = adv.aantalPixelsLeft + "px";
}

function doSwimming(adv){
    if(adv.aantalPixelsTop > 170 && adv.omhoog){
        adv.aantalPixelsTop--;
    }else if(adv.aantalPixelsTop < 185 && !adv.omhoog){
        adv.aantalPixelsTop++;
    }else{
        adv.omhoog = !adv.omhoog;
    }

    adv.logo.style.top = adv.aantalPixelsTop + "px";

    if(adv.aantalPixelsLeft <= 0){
        clearInterval(adv.timerDrie);
    }
}