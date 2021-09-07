
function showNotie(response) {
    if (response == null || response.Message == null || response.Message == undefined || response.Message == "") {
        return 0;
    }

    if (response.IsSuccess) {
        notie.alert(1, response.Message, 10);
    }
    else {
        notie.alert(3, response.Message, 10);
    }
    return 1000;
}

function activateCheckBoxList() {

    $("input[id*='item-checkbox']").each(function (item) {
        $(this).on("change", function () {
            if ($("input[id *= 'item-checkbox']:checked").length > 0) {
                var button = $('button[data-type="deleteMultiple"]');
                if ($(button).hasClass("uk-hidden")) {
                    $(button).removeClass("uk-hidden");
                }
            }
            else {
                var button = $('button[data-type="deleteMultiple"]');
                if (!$(button).hasClass("uk-hidden")) {
                    button.addClass("uk-hidden");
                }
            }
        });
    });

}

$(document).ready(function () {

    $('input, textarea').autogrow();

    activateCheckBoxList();

    var formIds = [

        "ProductAddForm",
        "ProductEditForm",
        "CategoryAddForm",
        "CategoryEditForm",
        "SubCategoryAddForm",
        "SubCategoryEditForm",
        "BrandAddForm",
        "BrandEditForm",
        "ChangePasswordForm",
        "LogOutForm",
        "CreateUserForm"
    ];

    $.each(formIds, function (index, formId) {

        formId = "#" + formId;

        if (!($(formId).length)) {
            return;
        };

        var clearForm = $(formId).data("clear-form");
        clearForm = (clearForm == null) ? true : false;

        $(formId).ajaxForm({
            formId: formId,
            dataType: 'json',
            beforeSubmit: function (formData, jqForm, options) {

                if (!$(options.formId).valid()) return false;

                if (options.formId === ("#" + formIds[0]) || options.formId === ("#" + formIds[1])) {
                    if ($("#ProductImage").val() == "") {
                        $("[data-valmsg-for=\"ProductImage\"]").html($("#ProductImage").data("val-required"));
                        return false;
                    }
                }

                oframe.blockUI();
            },
            success: function (responseText, statusText, xhr, $form) {

                oframe.unblockUI();
                debugger;
                var id = $form.attr("id");
                var formId = "#" + id;
                var responseInitMethod = id + "Response";
                window[responseInitMethod](responseText, formId);
            },
            clearForm: false,
            resetForm: true
        });

    });

    $("[data-update-img]").on("change", function () {

        youtubeUrl = $(this).val();
        if (youtubeUrl.trim() == "") return;
        var img = $(this).data("update-img");
        $(img).attr("src", oframe.youtubeGetThumbnail(youtubeUrl));

    });

    $(".youtube-drag-box").each(function () {

        $(this).on("change", function () {

            var ytIdBox = $(this);
            var titleBox = $($(this).attr("data-yt-title"));
            var thumbnailBox = $($(this).attr("data-yt-img"));

            var ytId = oframe.youtubeParseId(ytIdBox.val());

            if (ytId == "") {
                ytIdBox.val("")
                titleBox.val("")
                thumbnailBox.attr("src", $(thumbnailBox).data("default-image"))
                return;
            }

            var ytApiKey = "AIzaSyCLd72G1vb1L_pX9Hshvfg7jZkOU1lp_eo",
                ytDataEndPointUrl = "https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" + ytId + "&key=" + ytApiKey;

            var jqxhr = $.getJSON(ytDataEndPointUrl)
                .done(function (data) {

                    ytIdBox.val(ytId);
                    titleBox.val(data.items[0].snippet.title);
                    $(thumbnailBox).attr("src", oframe.youtubeGetThumbnail(ytId))
                })
                .fail(function () {

                    console.log("error, see network tab for response details");
                });

        })
    })
});


function deleteWithConfirm(e) {


    var url = $(e).data("post-url");

    var res = UIKit.Confirm("Are you Sure to Delete this Video?")

}

var imageDropZone = null;

function initProductImageUpload(formName) {

    var imageForm = formName;
    var zone = imageForm + " div.m_dropzone";
    var imagePostUrl = $(zone).data("url");

    debugger;

    imageDropZone = new Dropzone(zone, {
        url: imagePostUrl,
        maxFiles: 1,
        uploadMultiple: false,
        acceptedFiles: ".jpg,.png,.jpeg,.gif,.bmp,.svg",
        createImageThumbnails: true
    });

    var imageField = $(imageForm).find("#ProductImage");

    imageDropZone.on("removedfile", function (file) {

        if (file.xhr != null) {
            var rsp = JSON.parse(file.xhr.response);
            imageField.val("");
            imageDropZone.enable();
        }
    });

    imageDropZone.on("success", function (file) {

        var rsp = JSON.parse(file.xhr.response);

        if (rsp.IsSuccess) {
            $("[data-valmsg-for=\"ProductImage\"]").empty();
            imageField.val(rsp.Result);
            imageDropZone.disable();
        }
    });
}



function ProductAddFormResponse(response, formId) {

    imageDropZone.removeAllFiles();
    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function ProductEditFormResponse(response, formId) {

    imageDropZone.removeAllFiles();
    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}


function CategoryAddFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function CategoryEditFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    } else {
        $("#CategoryName").val("");
        $("#CategoryDescription").val("-");
        $("#CategoryName").focus();
    }
}


function SubCategoryAddFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
    else {
        $("#SubCategoryName").val("");
        $("#SubCategoryDescription").val("-");
        $("#SubCategoryName").focus();
    }
}


function BrandAddFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function BrandEditFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}


function SubCategoryEditFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function ChangePasswordFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function LogOutFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}


function CreateUserFormResponse(response, formId) {

    var waitTime = showNotie(response);

    var returnUrl = $(formId).data("return-url");

    if (returnUrl != null && returnUrl.length) {
        window.setTimeout(function () {
            window.location = returnUrl;
        }, waitTime);
    }
}

function openPopupDirect(vType, url, insideCloseBtn, data, postUrl, popUp, popUpBody) {
    var param = {
        url: url,
        vType: vType,
        postUrl: postUrl,
        popUp: popUp != null ? popUp : ".popUp",
        popUpBody: popUpBody != null ? popUpBody : ".portlet-body",
        closeBtnInside: insideCloseBtn == null ? false : insideCloseBtn
    };
    openMagnific(param);
}


function openPopup(e) {
    var vType = $(e).data("type");
    var url = $(e).data("url");
    var postUrl = $(e).data("post-url");
    var imagePostUrl = $(e).data("image-post-url");
    var popUp = $(e).data("popup");
    var popUpBody = $(e).data("popup-body");
    var data;

    if (vType == "deleteMultiple") {
        var ids = "";
        $("input[id*='item-checkbox']:checked").each(function () {
            ids += $(this).data("id") + ",";
        });
        data = { ids: ids };
    } else if (vType == "userRoleUpdate") {
        var data = { userId: $(e).data("user-id") };
    }

    var param = {
        url: url,
        vType: vType,
        postUrl: postUrl,
        data: data,
        imagePostUrl: imagePostUrl,
        popUp: popUp != null ? popUp : ".popUp",
        popUpBody: popUpBody != null ? popUpBody : ".portlet-body",
        closeBtnInside: false
    };

    openMagnific(param);
}

function openMagnific(param) {
    $.magnificPopup.open({
        items: {
            src: param.popUp
        },
        type: 'inline',
        closeBtnInside: param.closeBtnInside,
        midClick: true,
        callbacks: {
            open: function () {
                loadTypeContent(param);
            },
            close: function () {
                $(param.popUpBody).html("");
            }
        }
    });
}


function loadTypeContent(param) {

    oframe.blockUI();

    $.ajax({
        url: param.url,
        type: "GET",
        data: param.data,
        beforeSend: function () {
            oframe.blockUI();
        },
        success: function (response) {
            oframe.unblockUI();
            $(param.popUpBody).html(response);

            if (param.vType === "deleteMultiple") {

                InitDeleteMultiplePopup(param);

            } else if (param.vType === "userRoleUpdate") {

                InitUserRoleUpdatedPopup(param);

            } else {
                InitDeletePopup(param);
            }

        },
        error: function (e) {
            oframe.unblockUI();
            $.magnificPopup.close();
            notie.alert(3, "Some Error Occurred", 10);
        }
    });

}

function InitUserRoleUpdatedPopup(param) {

    var userRoleUpdateForm = $("#UpdateRoleDialogForm");

    var closeBtn = $(userRoleUpdateForm).find("#closeBtn");
    var updateBtn = $(userRoleUpdateForm).find("#updateBtn");;
    var reqVarificationToken = $("#UpdateRoleDialogForm [name='__RequestVerificationToken']").val();
    var _role = $("#UpdateRoleDialogForm #Role").val();

    $(closeBtn).click(function () {
        $.magnificPopup.close();
    });

    $(updateBtn).click(function () {

        var _roles = "";

        $("#UpdateRoleDialogForm input[type='checkbox']").each(function () {
            _roles += $(this).data("role-id") + ":" + $(this).is(":checked") + ",";
        });

        $.ajax({
            url: param.postUrl,
            data: { __RequestVerificationToken: reqVarificationToken, roles: _roles, userId: param.data.userId },
            type: "POST",
            beforeSend: function () {
                oframe.blockUI();
            },
            success: function (response) {

                if (response.IsSuccess) {
                    notie.alert(1, response.Message, 5);
                }
                else {
                    notie.alert(3, response.Message, 5);
                }
                $.magnificPopup.close();

                window.setTimeout(function () {
                    location.reload();
                }, 2000);
            },
            error: function (e) {
                oframe.unblockUI();
                $.magnificPopup.close();
                notie.alert(3, "Some Error Occurred", 10);
            }
        });

    });

}

function InitDeleteMultiplePopup(param) {

    var DeleteForm = $("#DeleteMultipleDialogForm");

    var closeBtn = $(DeleteForm).find("#closeBtn");
    var deleteBtn = $(DeleteForm).find("#deleteBtn");;
    var reqVarificationToken = $("#DeleteMultipleDialogForm [name='__RequestVerificationToken']").val();

    $(closeBtn).click(function () {
        $.magnificPopup.close();
    });

    $(deleteBtn).click(function () {
        $.ajax({
            url: param.postUrl,
            data: { __RequestVerificationToken: reqVarificationToken, ids: param.data.ids },
            type: "POST",
            beforeSend: function () {
                oframe.blockUI();
            },
            success: function (response) {

                if (response.IsSuccess) {
                    notie.alert(1, response.Message, 5);
                }
                else {
                    notie.alert(3, response.Message, 5);
                }
                $.magnificPopup.close();

                window.setTimeout(function () {
                    location.reload();
                }, 2000);
            },
            error: function (e) {
                oframe.unblockUI();
                $.magnificPopup.close();
                notie.alert(3, "Some Error Occurred", 10);
            }
        });

    });

}

function InitDeletePopup(param) {

    var DeleteForm = $("#DeleteDialogForm");

    var closeBtn = $(DeleteForm).find("#closeBtn");
    var deleteBtn = $(DeleteForm).find("#deleteBtn");;
    var reqVarificationToken = $("#DeleteDialogForm [name='__RequestVerificationToken']").val();

    $(closeBtn).click(function () {
        $.magnificPopup.close();
    });

    $(deleteBtn).click(function () {
        $.ajax({
            url: param.postUrl,
            data: { __RequestVerificationToken: reqVarificationToken },
            type: "POST",
            beforeSend: function () {
                oframe.blockUI();
            },
            success: function (response) {

                if (response.IsSuccess) {
                    notie.alert(1, response.Message, 5);
                }
                else {
                    notie.alert(3, response.Message, 5);
                }
                $.magnificPopup.close();

                window.setTimeout(function () {
                    location.reload();
                }, 2000);
            },
            error: function (e) {
                oframe.unblockUI();
                $.magnificPopup.close();
                notie.alert(3, "Some Error Occurred", 10);
            }
        });

    });
}

function initDependentDropdowns(loadWithInit) {

    $("[data-dependant]").each(function () {

        var _self = $(this);

        var dependant = $($(_self).data("dependant"));
        if (dependant == null || dependant == undefined) return;

        if (loadWithInit) {
            loadDependantData(_self);
        } else {
            dependant.removeAttr("disabled");
        }

        $(_self).on("change", function () {
            var self = $(this);

            loadDependantData(self);

        });

        function loadDependantData(self) {

            var loadUrl = dependant.data("url");

            $.ajax({
                url: loadUrl,
                method: "GET",
                data: { id: self.val() },
                success: function (result) {
                    if (result.IsSuccess) {
                        var _option = "<option value='__value__'>__text__</option>";
                        debugger;
                        dependant.html("");
                        dependant.removeAttr("disabled");
                        dependant.append("<option selected='selected' value='-1' disabled='disabled'>-- Select --</option>");
                        $.each(result.Object, function (key, value) {
                            var option = _option;
                            option = option.replace("__value__", value.Value).replace("__text__", value.Text);
                            if (value.Selected) {
                                option = options.replace("<option ", "<option selected='selected'");
                            }
                            if (value.Disabled) {
                                option = options.replace("<option ", "<option disabled='disabled'");
                            }
                            dependant.append(option);
                        });
                        dependant.trigger("change");
                    }
                    else {
                        dependant.html("");
                        dependant.attr("disabled", "disabled");
                        dependant.val("");
                        dependant.append("<option selected='selected'>-- Select --</option>");
                        dependant.trigger("change");
                    }
                }
            });

        }

    });

}

function generateSiteMap(e) {

    var url = $(e).data("post-url");

    $.ajax({
        url: url,
        type: "GET",
        beforeSend: function () {
            oframe.blockUI();
        },
        success: function (response) {
            oframe.unblockUI();
            if (response.IsSuccess == true) {
                notie.alert(1, response.Message, 10);
            }
        },
        error: function (e) {
            oframe.unblockUI();
            notie.alert(3, "Some Error Occurred", 10);
        }
    });
}
function loadDetailsPage(e) {

    //alert($(e).data("href"));
    oframe.blockUI();

    $.ajax({
        url: $(e).data("href"),
        method: "get",
        success: function (res) {
            $("#detailPlaceHolder").html(res);
            $("#detailPlaceHolder").removeClass("uk-hidden");
            $("#gridContainer").attr("uk-grid", "");
            $("#gridContainer").addClass("uk-grid");
            $("#listContainer").addClass("uk-width-expand@m");
        },
        error: function (res) {
            $("#detailPlaceHolder").html("");
            $("#detailPlaceHolder").addClass("uk-hidden");
            $("#gridContainer").removeAttr("uk-grid");
            $("#gridContainer").removeClass("uk-grid");
            $("#listContainer").removeClass("uk-width-expand@m");
        },
        complete: function (res) {
            oframe.unblockUI();
        }
    });

}

function removeDetails() {
    $("#detailPlaceHolder").html("");
    $("#detailPlaceHolder").addClass("uk-hidden");
    $("#gridContainer").removeAttr("uk-grid");
    $("#gridContainer").removeClass("uk-grid");
    $("#listContainer").removeClass("uk-width-expand@m");
}


var loaderPanel = `<div id="loaderPanel" class="loader-container"> <div class="refresh-loader large"> </div> </div>`;

$("#listContainer").ready(function () {


    var panel = $("#listContainer");

    $(panel).append(loaderPanel);

    if ($("#listContainer").data("sync-refresh") == true) {

        setInterval(function () {

            loadListPage(panel.data("href"));

        }, 10000)

    } else {
        loadListPage(panel.data("href"));
    }
});

function loadListPage(listUrl) {

    var listPanel = $("#listContainer");

    defaultUrl = listPanel.data("href");

    if (listUrl != defaultUrl) {
        removeDetails();
        listPanel.html(loaderPanel);
        listPanel.data("href", listUrl);
        $("#loader").addClass("uk-hidden");
    }
    else {
        $("#loader").removeClass("uk-hidden");
    }

    $.ajax({
        url: listUrl,
        method: "get",
        success: function (res) {
            listPanel.html(res);
            activateCheckBoxList();
        },
        error: function (res) {
            showNotie({ Message: "Some Error Occurred" })
        },
        complete: function () {
            oframe.unblockUI();
            if (!$("#loader").hasClass("uk-hidden")) $("#loader").addClass("uk-hidden");
        }
    });
}
