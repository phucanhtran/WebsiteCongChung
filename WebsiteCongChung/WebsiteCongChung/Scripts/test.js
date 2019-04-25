var onComplete = function(data) {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "positionClass": "toast-bottom-right",
        "onclick": null,
        "showDuration": "1000",
        "hideDuration": "1000",
        "timeOut": "2000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };
    toastr["success"]("Tạo phiếu yêu cầu thành công!</br>Chức năng in sẽ hoàn thành trong tương lai.", "Thông Báo");

    $("#SoHopDong").val("2019042300003");

    printPhieuYeuCau();
}

var KiemTraTS = function () {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "positionClass": "toast-bottom-right",
        "onclick": null,
        "showDuration": "1000",
        "hideDuration": "1000",
        "timeOut": "1000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };
    toastr["success"]("Tài sản này chưa có trong hợp đồng nào", "Thông Báo");
}

function printPhieuYeuCau() {
    var htmlStart =
        '<!DOCTYPE html>' +
        '<html>' +
        '<head>' +
        '<meta charset="utf-8" />' +
        '<title>Kendo UI Grid</title>' +
        '<link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" /> ' +
        '<body>';

    var printableContent = '';
    printableContent += '<p style="text-align:right"><em><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Mẫu số 01/PYC</span></span></em></p>'
        + '<p style="text-align:right">&nbsp;</p>'

        + '<p style="text-align:center"><span style="font-size:19px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><strong>CỘNG HO&Agrave; X&Atilde; HỘI CHỦ NGHĨA VIỆT NAM</strong></span></span></p>'

        + '<p style="text-align:center"><span style="font-size:19px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Độc Lập - Tự Do - Hạnh Ph&uacute;c</span></span></p>'

        + '<p style="text-align:center"><span style="font-size:19px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">----------------</span></span></p>'

        + '<p style="text-align:center"><span style="font-size:19px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><strong>PHIẾU Y&Ecirc;U CẦU C&Ocirc;NG CHỨNG HỢP ĐỒNG, GIAO DỊCH</strong></span></span></p>'

        + '<p style="text-align:center">&nbsp;</p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">K&iacute;nh gửi: Văn ph&ograve;ng C&ocirc;ng chứng Quận 10, TP.HCM</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Họ v&agrave; t&ecirc;n người nộp phiếu:</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">&Ocirc;ng/B&agrave;:&nbsp;</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Sinh năm:</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">CMND/CCCD/Hộ Chiếu:</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Thường tr&uacute;:</span></span></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">Nội dung y&ecirc;u cầu c&ocirc;ng chứng: asdasd</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">C&aacute;c giấy tờ nộp k&egrave;m theo Phiếu n&agrave;y gồm c&oacute; :</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">...........................................................................................................................................</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">...........................................................................................................................................</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">...........................................................................................................................................</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">...........................................................................................................................................</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify"><strong><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif">...........................................................................................................................................</span></span></strong></p>'

        + '<p style="margin-left:80px; text-align:justify">&nbsp;</p>'

        + '<p style="margin-left:80px; text-align:left"><em><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><em>Thời gian nhận phiếu ......... giờ, ng&agrave;y&nbsp;</em></span></span></em></p>'

        + '<p style="margin-left:80px"><em><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><strong>NGƯỜI NHẬN PHIẾU&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;NGƯỜI NỘP PHIẾU</strong></span></span></em></p>'

        + '<p style="margin-left:80px; text-align:justify"><em><span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><em>(K&yacute; v&agrave; ghi r&otilde; họ t&ecirc;n)</em></span></span>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<span style="font-size:17px"><span style="font-family:&quot;Times New Roman&quot;,Times,serif"><em>(K&yacute; v&agrave; ghi r&otilde; họ t&ecirc;n)</em></span></span></em></p>'
    CKEDITOR.instances['InPhieuYeuCauEditor'].setData(printableContent);
    CKEDITOR.instances['InPhieuYeuCauEditor'].execCommand('print');
}

function createTreeView(templates) {
    var mapItems = [];
    var dataSource = [];

    templates.forEach(function (element) {
        element.expanded = false;
        element.spriteCssClass = "hide";
        element.text = element.Name;
        if (element.ParentId == "") {
            element.expanded = true;
            element.items = [];
            dataSource.push(element);
            mapItems[element.Id] = element.items;
        } else {
            if (mapItems[element.Id] == null) {
                element.items = [];
                mapItems[element.Id] = element.items;
            }

            if (mapItems[element.ParentId] != null)
                mapItems[element.ParentId].push(element);
        }
    });
    return dataSource;
}
$(document).ready(function () {
    var onChange = function (e) {
        console.log("event :: select");
        $.ajax({
            url: "../HopDong/GetNoiDungHopDong",
            method: "GET",
            data: "{maLoaiHD: " + e.sender.element.val().Id + "}",
            success: function (response) {
                CKEDITOR.instances['editor1'].setData(response.NoiDung);
            },
            error: function (response) {
            }
        });
    }

    $.ajax({
        url: "../General/GetTemplates",
        method: "POST",
        success: function (response) {
            var dataSources = createTreeView(response);
            $("#dropdowntree").kendoDropDownTree({
                template: kendo.template($("#dropdowntree-template").html()),
                valueTemplate: kendo.template($("#dropdowntree-value-template").html()),
                dataTextField: "text",
                dataSpriteCssClassField: "spriteCssClass",
                dataSource: dataSources,
                filter: "startswith",
                change: onChange
            });
        },
        error: function (response) {
        }
    });
});