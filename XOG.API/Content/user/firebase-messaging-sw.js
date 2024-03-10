importScripts('https://www.gstatic.com/firebasejs/9.0.1/firebase-app-compat.js');
importScripts('https://www.gstatic.com/firebasejs/9.0.1/firebase-messaging-compat.js');

/*Update this config*/
var config = {
    apiKey: "AIzaSyC9v1_yLcS5F-gygLlhCzX6R23Mb66mnaE",
    authDomain: "xog-app.firebaseapp.com",
    projectId: "xog-app",
    storageBucket: "xog-app.appspot.com",
    messagingSenderId: "673895912821",
    appId: "1:673895912821:web:35dd83c2011d49c6ff6f3c",
    measurementId: "G-E8YD0C5LZJ"
  };

firebase.initializeApp(config);
const messaging = firebase.messaging();


messaging.onBackgroundMessage(function(payload) {

  console.log('[firebase-messaging-sw.js] Received background message ', payload); 
 
 
});