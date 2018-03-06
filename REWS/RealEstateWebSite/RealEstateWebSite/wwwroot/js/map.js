function initMap() {

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 8,
        center: { lat: 42.7236327, lng: 24.2724276 },
        disableDefaultUI: false,
        scrollwheel: false,
        styles: mapStyles,
        mapTypeControlOptions: {
            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
            position: google.maps.ControlPosition.BOTTOM_CENTER
        },
        panControl: false,
        zoomControl: true,
        zoomControlOptions: {
            style: google.maps.ZoomControlStyle.LARGE,
            position: google.maps.ControlPosition.RIGHT_TOP
        }
    });

    // Create an array of alphabetical characters used to label the markers.
    var labels = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';

    // Add some markers to the map.
    // Note: The code uses the JavaScript Array.prototype.map() method to
    // create an array of markers based on a given "locations" array.
    // The map() method here has nothing to do with the Google Maps API.
    var iconBase = 'https://maps.google.com/mapfiles/kml/pal3/';

    var markers = locations.map(function (location, i) {
        return new google.maps.Marker({
            position: location,
            icon: iconBase + 'icon48.png'
        });
    });

    // Add a marker clusterer to manage the markers.
    var markerCluster = new MarkerClusterer(map, markers,
        { imagePath: 'https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m' });
}
var locations = [
    { lat: 42.668711, lng: 23.300835 },
    { lat: 42.662998, lng: 23.320533 },
    { lat: 42.683563, lng: 23.328183 },
    { lat: 42.695927, lng: 23.344019 },
    { lat: -33.851702, lng: 151.216968 },
    { lat: -34.671264, lng: 150.863657 },
    { lat: -35.304724, lng: 148.662905 },
    { lat: -36.817685, lng: 175.699196 },
    { lat: -36.828611, lng: 175.790222 },
    { lat: -37.750000, lng: 145.116667 },
    { lat: -37.759859, lng: 145.128708 },
    { lat: -37.765015, lng: 145.133858 },
    { lat: -37.770104, lng: 145.143299 },
    { lat: -37.773700, lng: 145.145187 },
    { lat: -37.774785, lng: 145.137978 },
    { lat: -37.819616, lng: 144.968119 },
    { lat: -38.330766, lng: 144.695692 },
    { lat: -39.927193, lng: 175.053218 },
    { lat: -41.330162, lng: 174.865694 },
    { lat: -42.734358, lng: 147.439506 },
    { lat: -42.734358, lng: 147.501315 },
    { lat: -42.735258, lng: 147.438000 },
    { lat: -43.999792, lng: 170.463352 }
]

// Autocomplete address ------------------------------------------------------------------------------------------------

// This example displays an address form, using the autocomplete feature
// of the Google Places API to help users fill in the information.

// This example requires the Places library. Include the libraries=places
// parameter when you first load the API. For example:
// <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&libraries=places">

var placeSearch, autocomplete;
var componentForm = {
    street_number: 'short_name',
    route: 'long_name',
    locality: 'long_name',
    administrative_area_level_1: 'short_name',
    country: 'long_name',
    postal_code: 'short_name'
};

function initAutocomplete() {
    // Create the autocomplete object, restricting the search to geographical
    // location types.
    autocomplete = new google.maps.places.Autocomplete(
        (document.getElementById('autocomplete')),
        { types: ['geocode'] });
}

//function fillInAddress() {
//    // Get the place details from the autocomplete object.
//    var place = autocomplete.getPlace();

//    for (var component in componentForm) {
//        document.getElementById(component).value = '';
//        document.getElementById(component).disabled = false;
//    }

//    // Get each component of the address from the place details
//    // and fill the corresponding field on the form.
//    for (var i = 0; i < place.address_components.length; i++) {
//        var addressType = place.address_components[i].types[0];
//        if (componentForm[addressType]) {
//            var val = place.address_components[i][componentForm[addressType]];
//            document.getElementById(addressType).value = val;
//        }
//    }
//}

// Bias the autocomplete object to the user's geographical location,
// as supplied by the browser's 'navigator.geolocation' object.
function geolocate() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var geolocation = {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };
            var circle = new google.maps.Circle({
                center: geolocation,
                radius: position.coords.accuracy
            });
            autocomplete.setBounds(circle.getBounds());
        });
    }
}
    