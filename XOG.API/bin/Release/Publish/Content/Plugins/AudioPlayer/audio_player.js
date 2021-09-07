jQuery.fn.AudioPlayer = function (options) {

    var defaults = { 
        album_image: "/content/plugins/AudioPlayer/images/speakers.jpg",
        loop: false,
        autoplay: false, 
        initVolume: 7
    };

    var settings = $.extend({}, defaults, options);

    var controlTags = '<div id="audio_container" class="audio_container uk-padding-small uk-margin-top">' + 
                          '<canvas id="visualizer"></canvas>' +
                           '<div id="audio_player">' +
                                   '<div class="audio_player_controls" id="player_controls">' +
                                       '<div class="uk-display-block">' +
                                           '<button id="play_pause" class="uk-button uk-button-icon" uk-icon="icon: play"></button>' +
                                       '</div>' +

                                       '<input id="volume" type="range" min="0" max="10" value="">' +

                                        '<div id="tracker_container">' +
                                           '<div class="timer_container">' +
                                               '<span id="current_time"></span><span id="time_duration"></span>' +
                                           '</div>' +
                                         '<canvas id="tracker"></canvas>' +
                                       '<input id="seek" type="range" min="0" max="" value="0">' +

                                    '</div>' +
                                 '</div>' +
                            '</div>' +
                     ' </div>';

    var canvas, ctx, source, context,
        analyser, fbc_array, bars, bar_x,
        bar_width, bar_height, seek_canvas,
        seek_ctx, rainbow, bars;

    var audio, audioPlayer, player, tracker,
        playerControls, rainbow, playButton, volume, seek, currentTime, durationTime;

    player = $(this);

    function frameLooper() {

        window.requestAnimationFrame(frameLooper);
        fbc_array = new Uint8Array(analyser.frequencyBinCount);
        analyser.getByteFrequencyData(fbc_array);
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        var hasMask = false;
        var j = 0;
        var k = 20;

        for (var i = 50; i < bars; i += 2) {

            var mid_w = canvas.width / 2;
            var mid_h = canvas.height / 2;

            bar_x_left = j++ * 1.8;
            bar_x_right = canvas.width - j++ * 1.8;
            bar_width = 1;

            if (bar_x_right < mid_w && bar_x_left > mid_w / 2) break;

            if (fbc_array[i] > 0) hasMask = true;

            bar_height = -(fbc_array[i] - (fbc_array[i] / 4));
            bar_height = -(fbc_array[i] - (fbc_array[i] / 4));

            ctx.fillStyle = "#" + rainbow.colorAt(j++);
            ctx.fillRect(bar_x_left, mid_h - bar_height / 2 - 5, bar_width, bar_height);
            ctx.fillRect(bar_x_right, mid_h - bar_height / 2 - 5, bar_width, bar_height);


        }
        if (hasMask || settings.showbase) {

            ctx.fillStyle = "rgba(256, 256, 256, 0.8)";
            ctx.fillRect(0, canvas.height / 2 - 0.2, canvas.width, 0.4);

            var grd = ctx.createLinearGradient(0, 0, 0, 170);
            grd.addColorStop(0, "rgba(0, 0, 0, 2)");
            grd.addColorStop(0.1, "rgba(0, 0, 0, 1)");
            grd.addColorStop(0.2, "rgba(0, 0, 0, 0.8)");
            grd.addColorStop(0.5, "rgba(256, 256, 256, 0.2)");
            grd.addColorStop(1, "rgba(256,256,256, 0.05)");

            ctx.fillStyle = grd;
            ctx.fillRect(0, canvas.height / 2 + 0.4, canvas.width, canvas.height / 2 - 0.4);
        }
    }

    return {
        init: function () {

            var ref = this;

            audio = new Audio();
            source = settings.source;

            audio.src = source;


            audio.controls = false;
            audio.loop = settings.loop;
            audio.autoplay = settings.autoplay;
            audio.preload = settings.preload;
            audio.volume = settings.initVolume / 10;

            canvas = player.find("#visualizer").get(0);
            audioPlayer = player.find("#audio_player").get(0);
            //$(audioPlayer).empty();
            //$(audioPlayer).html(controlTags);
            seek_canvas = player.find("#tracker").get(0);
            playButton = player.find("#play_pause");
            volume = player.find("#volume");
            seek = player.find("#seek");
            currentTime = player.find("#current_time");
            durationTime = player.find("#time_duration");
            playerControls = player.find("#player_controls");

            //audioPlayer.append(audio);
            context = new AudioContext();
            analyser = context.createAnalyser();
            ctx = canvas.getContext('2d');

            source = context.createMediaElementSource(audio);
            source.connect(analyser);
            analyser.connect(context.destination);

            bars = canvas.width / 2 + canvas.width / 4;

            if (settings.rainbow != null) {
                rainbow = settings.rainbow;
            }
            else {
                rainbow = new Rainbow();
                var items = bars / 3;
                rainbow.setNumberRange(1, items);
                rainbow.setSpectrum('#DD7F00', '#5FBF2C');
                this.frameLooper();
            }

            seek_ctx = seek_canvas.getContext('2d');

            $(playButton).click(function () {
                if ($(playButton).attr("data-reset") === "true") {
                    $(this).removeAttr("data-reset");

                    $(playButton).attr("uk-icon", "icon: play");
                    ref.reset();
                    return;
                }
                if (audio.duration > 0 && !audio.paused) {
                    ref.pause();
                }
                else {
                    ref.play();
                }
            });

            audio.onplay = function () {
                $(playButton).attr("uk-icon", "icon: thumbnails");
            }

            audio.onpause = function () {
                $(playButton).attr("uk-icon", "icon: play");
            }

            $(volume).change(function () {
                audio.volume = parseFloat(this.value / 10);
            });

            $(seek).bind("change", function () {
                audio.currentTime = $(this).val();
                ref.updateSeek($(this).val());
            });

            var disable = false;
            $(seek).bind("mousedown", function () {
                disable = true;
            });

            $(seek).bind("mouseup", function () {
                disable = false;
            });

            var rng = document.querySelector("input#seek");


            rng.addEventListener("mousedown", function () {
                window.requestAnimationFrame(function () {
                    ref.updateSeek(rng.value);
                });
            });

            rng.addEventListener("mousemove", function () {
                window.requestAnimationFrame(function () {
                    ref.updateSeek(rng.value);
                });
            });

            window.setTimeout(function () {
                ref.resizeContent();
            }, 500);


            $(window).resize(function () {
                ref.resizeContent();
            });

            audio.addEventListener('timeupdate', function () {
                //if (!disable) {
                var duration = parseInt(audio.duration);
                var currentTimeValue = audio.currentTime;

                $(currentTime).empty();
                $(currentTime).append(toHoursMinutesSeconds(currentTimeValue));

                $(durationTime).empty();
                $(durationTime).append(toHoursMinutesSeconds(duration));

                $(seek).val(currentTimeValue);
                $(seek).attr("max", duration);
                ref.updateSeek(currentTimeValue);
                //  }
            });

        },
        updateSeek: function (val) {
            seek_ctx.clearRect(0, 0, seek_canvas.width, seek_canvas.height);
            var seek_x = 0;
            var seek_y = 0;
            var seek_w = Math.ceil((val / audio.duration) * seek_canvas.width) + 2;
            var buffer_x = (Math.ceil((audio.buffered.end(audio.buffered.length - 1) / audio.duration) * seek_canvas.width) + 2);
            var seek_h = seek_canvas.height;
            seek_ctx.fillStyle = "#ccc";
            seek_ctx.fillRect(0, 0, buffer_x, seek_h);
            seek_ctx.fillStyle = "#A5C0Ef";
            seek_ctx.fillRect(0, 0, seek_w, seek_h);
            $(currentTime).empty();
            $(currentTime).append(toHoursMinutesSeconds(val));
        },
        resizeContent: function () {
            var wt = $(canvas).css("width");
            var ht = parseFloat(wt);
            $(canvas).css("height", ht);
            $(playerControls).css("width", wt);
        },
        play: function () {
            audio.play().catch(function () {
                notie.alert(2, "load error.. click reload..", 2);
                $(playButton).attr("data-reset", "true");
                $(playButton).attr("uk-icon", "icon: refresh");
            });
        },
        reset: function () {
            this.init();
        },
        pause: function () {
            audio.pause();
        },
        drop: function () {
            audio.pause();
            //audio = null; 
        },
        frameLooper: frameLooper
    }

};

var toHoursMinutesSeconds = (secs) => {
    var sec_num = parseInt(secs, 10);
    var hours = Math.floor(sec_num / 3600) % 24;
    var minutes = Math.floor(sec_num / 60) % 60;
    var seconds = sec_num % 60;
    return [hours, minutes, seconds]
        .map(v => v < 10 ? "0" + v : v)
        .filter((v, i) => v !== "00" || i > 0)
        .join(":");
}
