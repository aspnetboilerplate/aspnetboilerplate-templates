(function() {
    abp.event.on('abp.notifications.received', function (userNotification) {
        console.log(userNotification);
    });
})();