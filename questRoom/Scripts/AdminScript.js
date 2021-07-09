document.getElementById("addPhone").addEventListener("click", function () {

    var d = document.getElementById('addTelephoneDiv');
    d.insertAdjacentHTML('beforeend', '<div class="pictureLabel"><img src="/Images/icons8-phone-64.png" alt="Alternate Text" /><label class="labelAdd">Phone number: </label></div><input value="" class="inputAddTelephone" id="room_Telephones" name="room.Telephones" type="text"></div>');
});


(function ($) {

    $(document).on('click', '.galleryClass', function () {
        var d = document.getElementById('galleryAddPhotoBtn');
        d.insertAdjacentHTML('beforeend', "<br><input type='file' name='GalleryImageData' class='galleryClass' accept='image/*'>");})

})(jQuery);

