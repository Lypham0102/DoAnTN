// Import the functions you need from the SDKs you need

import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries
// Your web app's Firebase configuration
const firebaseConfig = {
    apiKey: "AIzaSyCiSaknvNYmF3wd578-plD_5NWSA7PyjSY",
    authDomain: "esp8266-database-inventor.firebaseapp.com",
    databaseURL: "https://esp8266-database-inventor-default-rtdb.firebaseio.com",
    projectId: "esp8266-database-inventor",
    storageBucket: "esp8266-database-inventor.appspot.com",
    messagingSenderId: "423165376147",
    appId: "1:423165376147:web:01b7d90369ef89bd5bff66",
    measurementId: "G-6Y0CS5BME0"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);

// Initialize Firebase

    analytics.ref("/TEMPERATURE").on("value", function (snapshot) {
    var tem = snapshot.val();
    document.getElementById("temp").innerHTML = tem;
    });
    analytics.ref("/HUMIDITY").on("value", function (snapshot) {
    var we = snapshot.val();
    document.getElementById("wet").innerHTML = we;
});

//import firebase from "firebase/app";
//import "firebase/database";

// TODO: Replace the following with your app's Firebase project configuration
// See: https://firebase.google.com/docs/web/learn-more#config-object
//const firebaseConfig = {
//    apiKey: "AIzaSyCiSaknvNYmF3wd578-plD_5NWSA7PyjSY",
//    authDomain: "esp8266-database-inventor.firebaseapp.com",
//    databaseURL: "https://esp8266-database-inventor-default-rtdb.firebaseio.com",
//    projectId: "esp8266-database-inventor",
//    storageBucket: "esp8266-database-inventor.appspot.com",
//    messagingSenderId: "423165376147",
//    appId: "1:423165376147:web:fa804a18f158927b5bff66"
//};

//// Initialize Firebase
//firebase.initializeApp(firebaseConfig);
////const app = initializeApp(firebaseConfig);
///*const auth = firebase.auth();*/
//var database = firebase.database();
//// Initialize Firebase Authentication and get a reference to the service
//database.ref("/TEMPERATURE").on("value", function (snapshot) {
//    var temp = snapshot.val();
//    document.getElementById("temp").innerHTML = temp;
//    });
////database.ref("TEMPERATURE").once("value")
////    .then(function (snapshot) {
////        // Xử lý kết quả snapshot
////        var tem = snapshot.val();
        
////        console.log(tem);
////        document.getElementById("temp").innerHTML = tem;
////    })
////    .catch(function (error) {
////        // Xử lý lỗi
////        console.error(error);
////    });

//    //auth.ref("/TEMPERATURE").on("value", function (snapshot) {
//    //    var temp = snapshot.val();
//    //    document.getElementById("temp").innerHTML = temp;
