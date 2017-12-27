# GeolabOldCar
Old car web 2
ძველი მანქანის შეკეთებისა და განახლების ვებგვერდი 

ძირითადი მახასიათებლები
ვებგვერდი არის ერთენოვანი: ინგლისური
მორგებულია მობილურ მოწყობილობებს 
ადმინისტრატორის პანელს აქვს ინტუიციური ინტერფეისი (ავტვირთავ მზა cms - ის html, css, js ფაილებს ხუტშაბათს ან პარასკევს)
სისტემა ინტეგრირებული უნდა იყოს შემდეგ ბრაუზერებთან:
IE 8+
Opera
Chrome
FireFox
Safary

ვებ-გვერდის მომხმარებლის ტიპები
ვებ-საიტის მომხმარებლები კლასიფიცირებულია შემდეგგვარად:
1) არა-ავტორიზებული მომხმარებლი (Public) - მომხმარებლი, რომლებსაც აქვთ წვდომა საიტზე, ყოველგვარი ავტორიზაციის გარეშე.
2) ვებ-გვერდის ადმინისტრატორი.


ვებგვერდი

რა არის ის ძირითადი კომპონენტები, რომლის გარეშეც ვებგვერდის გამოქვეყნება არ შეიძლება:

1. Home | მთავარი
    მთავარი გვერდი ყოველთვის მორგებულია ეკრანის ზომას, 
    შესაძლებელია ფოტოების დათვალიერება (სლაიდერი)
    სლაიდერი (ფოტო) მორგებულია ეკრანის ზომას
    ფოტოს ახლავს თარიღი და დასათაურება

2. Services | სერვისები
    სერვისებს აქვს დასათაურება
    სერვისების გვერდზე გამოტანილია 3 ძირითადი მომსახურება

3. Contact | კონტაქტი
    გამოყენებულია გუგლის რუკა (უმჯობეის google api-თ შემოტანა)
    აქვს საკონტაქტო ფორმა,
    თუ მომხმარებელმა ცარიელი დატოვა ველი, შესაბამისი შეტყობინებას ხედავს
    მომხმარებელი ხედავს შეტყობინებას გაგზავნის შემთხვევაში 
    (error and success messages)

4. Navigation | ნავიგაცია
    ნავიგაციის ღილაკი დინამიურად იცვლება (გახნსა დახურვა)
    მენიუზე მიჭერისას დინამიურად ისქროლება შესაბამის განყოფილებაზე

5. Footer
    copyright
    ვებგვერდის შექმნელები 🙂

    Features:   
    1) მთავარ გვერდზე parallax ეფექტის დამატება, შესაძლებელია ამ ბიბლიოთეკის გამოყენება: https://dixonandmoe.com/rellax/
    2) სერვისების გვერდზე @keyframe ანიმაციის დამატება

    
    
2. cms (content management system)
        რა არის ის ძირითადი კომპონენტები, რომლის გარეშეც ადმინისტრატორის პნელს აზრი არ აქვს:

        2.1. მოდულები: 

        1. Home | მთავარი
        შესაძლებელია დამატება, რედაქტირება და წაშლა:
        ფოტო
        თარიღი
        დასათაურება
 
2. Services | სერვისები
        შესაძლებელია დამატება, რედაქტირება და წაშლა
    სერვისის ფოტო (svg ფორმატში)
    დასათაურება

3. Social Links | სოციალური ქსელებისათის ბმულების დამატება
    შესაძლებელია მხოლოდ რედაქტირება:
    Facebook
    Google+
    twitter

4. Subscribers |  გამომწერები
        არ აქვს, რედაქტირების, წაშლის ან დამატების შესაძლებლობა, ჩანს
    მომხმარებლის სახელი
    ელექტრონული ფოსტა
    შევსების თარიღი (Feature)


2.2. ფუნქციონალი:
    1) Login Page | ავტორიზაციის გვერდი
    არსებული (ბაზაში წინასწარ შექმნილი) ელ.ფოსტით და პაროლით შესაძლებელია ავტორიზაციის გავლა. ვებგევრდის კონტეტნტის        ადმინისტრირებისათვის, იხ. ზემოთჩამოთვლილი მოდულები

    2) Contact form | კონტაქტის ფორმა
        საკონტაქტო ფორმის ვალიდაცია, გულისხმობს, რომ როგორც დიზაინშია, 
        მომხმარებელს არ აქვს უფლება დატოვოს ცარიელი/შეუვსებელი ტექსტური ველები 
        და სქესის მოსანიშნი სექცია, თუკი ცარიელს დატოვებს უნდა გამოუტანოს შესაბამისი
        შეტყობინება (error message)
        თუკი ყველა სავალდებულო ველი შეავსო, და გადააგზავნა, წარმატების შემტხვევაში
        უნდა გამოიტანოს შესაბამისი მესიჯი (success message)

Features:

    1) მოდული: Dashboard, როდესაც ადმინისტრატორის პანელში ლოგინდები ჩანს ეს მოდული, სადაც გამოტანილია:
        1.რამდენი სერვისია დამატებული
        2.რამდენი subscriber/სიახლეების გამომწერი ყავს ვებგვერდს
    2) ვალიდაცია, ველები, რომლის ცარელი დატოვებაც არ შეიძლება
        1.სერვისები - დასათაურება
        2.სლიდერი - დასათაურება
