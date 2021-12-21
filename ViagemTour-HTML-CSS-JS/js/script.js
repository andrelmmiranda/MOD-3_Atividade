$(window).scroll(()=>{
    if($(window).scrollTop() > 1){
        $('header').css("background-color", "var(--white)");
        $('h1 img').css("width", "75px");
        $('h1 img').attr('src', './img/logo.png');
        $('header a').css('color', 'var(--mediumBlue)');
    } else{
        $('header').css("background-color", "#8adad0");
        $('h1 img').css("width", "100px");
        $('h1 img').attr('src', './img/logo-white.png');
        $('header a').css('color', 'var(--white)');
    };
})

$('a[href^="#"]').on('click', function(e) {
    e.preventDefault();

    const href = $(this).attr('href')
    
    if(href === "#topo"){
        $('html, body').animate({ 
            scrollTop: 0
        }, 500);
    } else{
        const targetOffset = $(href).offset().top;
			
        $('html, body').animate({ 
            scrollTop: targetOffset - 100
        }, 500);
    }
});

