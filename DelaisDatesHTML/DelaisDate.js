var datePickerDeclarationAppel = document.getElementById('datePickerDeclarationAppel');
var datePickerMemoireAppelant = document.getElementById('datePickerMemoireAppelant');
var dateLimiteDepotMemoireAppelant = document.getElementById('dateLimiteDepotMemoireAppelant');
var dateLimiteDepotMemoireIntime = document.getElementById('dateLimiteDepotMemoireIntime');
var dateLimiteDepotMemoireMisEnCause = document.getElementById('dateLimiteDepotMemoireMisEnCause');
var reinitialiseButton = document.getElementById('reinitialiseButton');
var delaisMaxDepotMemoireAppelant = 3;
var delaisMaxDepotMemoireIntime = 2;
var delaisMaxDepotMemoireIntervenant = 4;
var holidays = [new Date(2022, 00, 01), new Date(2022, 03, 15), new Date(2022, 03, 18), new Date(2022, 04, 23), new Date(2022, 05, 24), new Date(2022, 06, 01), new Date(2022, 07, 01), new Date(2022, 08, 05), new Date(2022, 08, 30), new Date(2022, 09, 10), new Date(2022, 10, 11), new Date(2022, 11, 25), new Date(2022, 11, 26)]



datePickerDeclarationAppel.onchange = function() {
    var date = datePickerDeclarationAppel.value.toString().split("-");
    var day = date[2];
    var month = date[1]-1;
    var year = date[0];
    var newDate = new Date(year,month + delaisMaxDepotMemoireAppelant,day);
    var limiteDate = setDeclarationAppelDate(newDate, month);
    var limiteDateString = limiteDate.split("-");
    day = limiteDateString[2];
    month = limiteDateString[1]-1;
    year = limiteDateString[0];
    var dateIntime = new Date(year,month + delaisMaxDepotMemoireIntime,day);
    var dateMEC = new Date(year,month + delaisMaxDepotMemoireIntervenant,day);
    setDepotMemoireDate(dateIntime, dateMEC, month)
};

datePickerMemoireAppelant.onchange = function() {
    var date = datePickerMemoireAppelant.value.toString().split("-");
    var day = date[2];
    var month = date[1]-1;
    var year = date[0];

    var dateIntime = new Date(year,month + delaisMaxDepotMemoireIntime,day);
    var dateMEC = new Date(year,month + delaisMaxDepotMemoireIntervenant,day);
    setDepotMemoireDate(dateIntime, dateMEC, month)
};

reinitialiseButton.onclick = function() {
    datePickerDeclarationAppel.value = "";
    dateLimiteDepotMemoireAppelant.value = "";
    datePickerMemoireAppelant.value = "";
    dateLimiteDepotMemoireIntime.value = "";
    dateLimiteDepotMemoireMisEnCause.value = "";
}

function addDays(date, days) {
    var result = new Date(date);
    result.setDate(result.getDate() + days);
    return result;
}

function dateToString(date){
    var month = (date.getMonth() + 1).toString().length == 1 ? "0" + (date.getMonth() + 1) : (date.getMonth() + 1); 
    var day = date.getDate().toString().length == 1 ? "0" + date.getDate() : date.getDate(); 
    return date.getFullYear() + "-" + month + "-" + day;
}

function checkWeekendAndHoliday(date, initialMonth, monthLimit)
{
    var newDate = new Date(date);
    var days = 0;
    // sunday = 0, saturday = 6
    
    while ((holidays.find(element => dateToString(element) == dateToString(addDays(newDate,days))) != undefined || addDays(newDate,days).getDay() == 6 || addDays(newDate,days).getDay() == 0))
    {
        if (addDays(newDate,days).getDay() == 6)
        {
            days += 2;
        }
        else
        {
            days += 1;
        }
    }
    if (addDays(newDate,days).getMonth() - initialMonth > monthLimit){
        days = 0;
        while ((holidays.find(element => dateToString(element) == dateToString(addDays(newDate,days))) != undefined || addDays(newDate,days).getDay() == 6 || addDays(newDate,days).getDay() == 0))
        {
            if (addDays(newDate,days).getDay() == 0)
            {
                days -= 2;
            }
            else
            {
                days -= 1;
            }
        }
        newDate = addDays(newDate, days);
    }
    else{
        newDate = addDays(newDate, days);
    }
    return newDate;
}

function setDeclarationAppelDate(date, initialMonth){
    var dateChecked = checkWeekendAndHoliday(date, initialMonth, delaisMaxDepotMemoireAppelant);
    var stringDate = dateToString(dateChecked);
    dateLimiteDepotMemoireAppelant.value = stringDate;
    datePickerMemoireAppelant.value = stringDate;
    return stringDate;
}

function setDepotMemoireDate(dateIntime, dateMEC, initialMonth){
    var dateCheckedIntime = checkWeekendAndHoliday(dateIntime, initialMonth, delaisMaxDepotMemoireIntime);
    var stringDateIntime = dateToString(dateCheckedIntime);
    dateLimiteDepotMemoireIntime.value = stringDateIntime;

    var dateCheckedMEC = checkWeekendAndHoliday(dateMEC, initialMonth, delaisMaxDepotMemoireIntervenant);
    var stringDateMEC = dateToString(dateCheckedMEC);
    dateLimiteDepotMemoireMisEnCause.value = stringDateMEC;
}