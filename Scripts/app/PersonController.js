
var PersonController = function (personService) {

   
    
    var getPersonByName = function (name) {
        console.log(name);
        var param = { name: name };
        personService.GetPersonByName(param, "/Home/GetPersonByName", personGetdone, personGetfail);
    };

    var personGetdone = function (data) {
        if (data.result) {
            $("#Email").val(data.person.Email);
            $("#Age").val(data.person.Age);
        }
        
        console.log("Success", data);
    };

    var personGetfail = function () {
        console.log("Fail", data);
    };
    
    //end
    return {
        
        GetPersonByName: getPersonByName,
        
        
    };
}(PersonService);