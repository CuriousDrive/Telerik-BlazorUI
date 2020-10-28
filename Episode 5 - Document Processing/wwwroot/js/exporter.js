(function () {

    window.saveFile = function (bytesBase64, mimeType, fileName) {
        var fileUrl = "data:" + mimeType + ";base64," + bytesBase64;
        fetch(fileUrl)
            .then(response => response.blob())
            .then(blob => {
                var link = window.document.createElement("a");
                link.href = window.URL.createObjectURL(blob, { type: mimeType });
                link.download = fileName;
                document.body.appendChild(link);
                link.click();
                document.body.removeChild(link);
            });
    }
    window.getUploadedFile = (inputID) => {
        var inputEl = document.getElementById(inputID);
        if (inputEl.files.length == 0) {
            return "";
        }
        else if (inputEl.files[0].size > (4 * 1024 * 1024)) { // 4MB
            inputEl.value = "";
            alert("File size too large. Max allowed size is 4MB.");
            return "";
        }
        else if (inputEl.accept.length && inputEl.accept.indexOf(inputEl.files[0].name.split('.').pop()) < 0) {
            inputEl.value = "";
            alert("Allowed file types: " + inputEl.accept);
            return "";
        }
        const fileReader = new FileReader();
        return new Promise((resolve) => {
            fileReader.onloadend = function (e) {
                var data = {
                    fileName: inputEl.files[0].name,
                    fileData: e.target.result.split('base64,')[1]
                };
                resolve(data);
            };
            fileReader.readAsDataURL(inputEl.files[0]);
        });
    };

})();
