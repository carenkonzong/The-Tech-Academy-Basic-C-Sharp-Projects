[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(Insuree insuree)
{
    if (ModelState.IsValid)
    {
        decimal quote = 50m; // Base quote

        // Calculate age
        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

        // Age-based adjustments
        if (age <= 18)
            quote += 100;
        else if (age >= 19 && age <= 25)
            quote += 50;
        else
            quote += 25;

        // Car year adjustments
        if (insuree.CarYear < 2000)
            quote += 25;
        if (insuree.CarYear > 2015)
            quote += 25;

        // Car make/model adjustments
        if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.ToLower() == "porsche")
        {
            quote += 25;
            if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.ToLower() == "911 carrera")
                quote += 25;
        }

        // Speeding tickets
        quote += insuree.SpeedingTickets * 10;

        // DUI adjustment
        if (insuree.DUI)
            quote *= 1.25m;

        // Full coverage adjustment
        if (insuree.CoverageType) // true = full coverage
            quote *= 1.5m;

        // Assign final quote
        insuree.Quote = quote;

        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}
