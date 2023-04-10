using CoR_Pattern;

Withdraw wid = new(1, 190);
Worker worker = new("Islam");
Moderator mod = new("Rustem");
HeadOfDepartment hod = new("Namiq");

//bad codes

if (wid.Amount < 200)
    worker.Process(wid);
else if (wid.Amount < 400)
    mod.Process(wid);
else if (wid.Amount < 800)
    hod.Process(wid);


//good codes

//worker.SetNextApprover(mod);
//mod.SetNextApprover(hod);

//worker.Process(wid);