$('.menu-toggle').click(function() {
  
  $('.site-nav').toggleClass('site-nav--open', 500);
  $(this).toggleClass('open');

  var src = ($(this).attr('src') === '/Content/images/auto_logo_red.png')
      ? '/Content/images/auto_logo.png'
      : '/Content/images/auto_logo_red.png';
         $(this).attr('src', src)

         $('#main_logo').attr('src',src);

   $('.left_control').toggleClass('hide');  
   $('.right_control').toggleClass('hide');      

})

function initMap() {
        var uluru = {lat: 41.71751392, lng: 44.78465617};
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 12,
          center: uluru
        });
        var marker = new google.maps.Marker({
          position: uluru,
          map: map
        });
      }
