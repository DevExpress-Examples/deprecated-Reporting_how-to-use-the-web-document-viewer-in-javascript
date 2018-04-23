"use strict"

const host = 'http://localhost:54114/',
    reportUrl = ko.observable(null),
    reports = ko.observable([]),
    viewerOptions = {
        reportUrl,
        requestOptions: {
            host,
            invokeAction: "/WebDocumentViewer/Invoke"
        }
    }

$.post(host + "WebDocumentViewer/GetReports").done(result => {
	reports(result);
	if(result.length > 0)
		reportUrl(result[0].Value);
});

ko.applyBindings({ viewerOptions, reports, reportUrl });