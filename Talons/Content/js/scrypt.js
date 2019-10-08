function SubmitForm(Surname, Name,Secondname)
{
    $.ajax(
        {

            method: "POST",
            url: "/Home/Form",
            data: { Фамилия: Surname, name: Name, secondname: Secondname, birth_day: BirthDate, tel: Tel, email: Email, spec: specialty}


        }).fail(function () { alert("При передаче данных произошла ошибка!") })
        .done(function (context) { alert(context); });


}
 $(document).on('submit', 'form', function () {

    var Фамилия = $('input[name=Surname]').val();
    var Имя = $('input[name=Name]').val();
     var Отчество = $('input[name=Secondname]').val();
     var Дата_рождения = $('input[name=BirthDate]').val();
     var Телефон = $('input[name=Tel]').val();
     var Эмэил = $('input[name=Email]').val();
     var Специальностьid = $('select').val();
    

     if (Фамилия.length > 0) {
         if (Имя.length > 0) {

             if (Отчество.length > 0) {
                 alert("Ваша заявка принята");
             } else { alert("Введите отчество"); }

         } else { alert("Введите имя"); }

     } else { alert("введите фамилию");}
             



});
