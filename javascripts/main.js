$(function() {
    var linkRelease = 'https://github.com/LiliaUst/trainIrregularVerbs/releases/download/{0}/trainIrregularVerbs.zip';
    $.ajax({
        url: 'params.json',
        success: function(data) {
            if (data && data.version) {
                $('#download-zip').attr('href', linkRelease.replace('{0}', data.version));
            }
        }
    });
});