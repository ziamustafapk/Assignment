var PersonService = function () {
    
    var getPersonByName = function (param, url, done, fail) {
        $.get(url, param)
            .done(done)
            .fail(fail);
    };
    
    return {
        
        GetPersonByName: getPersonByName
        
    };
}();