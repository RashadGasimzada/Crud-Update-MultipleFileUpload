$(function () {
    let navheader = $(".navmenu ul li");
    let navcontent = $(".navmenu > div")
    let newactivecontent = $('.navmenu > div[data-id = '+ 1 +']');
    navheader.click(function () {
        let activeheader = $(".navmenu ul .active");
        if(activeheader.attr("data-id") != $(this).attr("data-id") ){
            activeheader.removeClass("active");
            $(this).addClass("active");
            let activecontent = $(".navmenu .activecontent");
            activecontent.removeClass("activecontent");
            let activepage = $(this).attr("data-id");
            let newactivecontent = $('.navmenu > div[data-id = '+ activepage +']');
            newactivecontent.addClass("activecontent");
            
        }
    })
    let fruit = document.querySelector(".fruit");
    let fruits = document.querySelector(".fruits");
    let bever = document.querySelector(".bever");
    let beverag = document.querySelector(".beverag")

    fruit.addEventListener("mouseover", function () {
            fruits.classList.remove("d-none");
    })
    fruit.addEventListener("click",function(){
        fruits.classList.add("d-none")
    })
    bever.addEventListener("mouseover", function () {
            beverag.classList.remove("d-none");
    })
    bever.addEventListener("click",function(){
        beverag.classList.add("d-none");
    })
    let allCatan=document.querySelector(".allCatan");
    let drobovik=document.querySelector(".drobovik");

    allCatan.addEventListener("mouseover",function(){
        drobovik.classList.remove("d-none");
    })
     allCatan.addEventListener("click",function(){
         drobovik.classList.add("d-none");
     })
    

})