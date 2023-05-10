//var configuration = {
//    iceServers: [
//        {
//            urls: 'stun:stun.l.google.com:19302'
//        }
//    ]
//};

//var peerConnection = new RTCPeerConnection(configuration);

//navigator.mediaDevices.getUserMedia({ video: true, audio: false })
//    .then(function (stream) {
//        var video = document.querySelector('video');
//        video.srcObject = stream;
//        video.onloadedmetadata = function (e) {
//            video.play();
//        };

//        stream.getTracks().forEach(function (track) {
//            peerConnection.addTrack(track, stream);
//        });
//    })
//    .catch(function (err) {
//        console.log(err);
//    });

//peerConnection.onicecandidate = function (event) {
//    if (event.candidate) {
//        // Send the candidate to the other peer
//    }
//};

//peerConnection.ontrack = function (event) {
//    var video = document.querySelector('video');
//    video.srcObject = event.streams[0];
//    video.onloadedmetadata = function (e) {
//        video.play();
//    };
//};

const constraints = { video: true, audio: false };
const cameraStream = await navigator.mediaDevices.getUserMedia(constraints);

const videoElement = document.querySelector("#camera-stream");
videoElement.srcObject = cameraStream;

navigator.mediaDevices.getUserMedia(constraints)
    .then(function (cameraStream) {
        const videoElement = document.querySelector("#camera-stream");
        videoElement.srcObject = cameraStream;
    })
    .catch(function (error) {
        console.error("Failed to access camera: ", error);
    });

