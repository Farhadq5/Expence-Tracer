using expence_Tracer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Db
builder.Services.AddDbContext<ApplicationDbContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();


//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQwNDYzMkAzMjMwMmUzNDJlMzBYblZ1UnZSanVKTERXbDg3VVBIbjVjQXVjemFXZjJ5UllDMk8vUG9NQklJPQ==;MzQwNDYzM0AzMjMwMmUzNDJlMzBqYkt6VUpHTnNxbkRoYkhLa0pJeisrVXNMRnlIYWtBUGxaTEZJSHV4TzBvPQ==;Mgo+DSMBaFt/QHRqVVhlWFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQFljTnxUd0BjWnxeeXJQQA==;Mgo+DSMBPh8sVXJ0S0J+XE9BclRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3pTcUdkWHpec3dVT2hdUA==;ORg4AjUWIQA/Gnt2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxXdkJhXn5bcHdWRmlUUEU=;NRAiBiAaIQQuGjN/V0Z+WE9EaFpGVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RckVkW3hfdXRWRWBVWEJx;MzQwNDYzOEAzMjMwMmUzNDJlMzBKcVp0VWgzZjN4SG8xMEtBa0JBSnZhWTdPaWdublo4NFN3eWVmUnQ1OHl3PQ==;MzQwNDYzOUAzMjMwMmUzNDJlMzBpZ2puK1ZVaVJpN2ZWUkxCRmhmdkcrcStnNGVQQUFYSnZuaHlDOHl1MENJPQ==;Mgo+DSMBMAY9C3t2VVhkQlFac1tJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxXdkJhXn5bcHdWR2BbVEc=;MzQwNDY0MUAzMjMwMmUzNDJlMzBrYnZkUStNMzBTRnoyOEhDblgvVFE5T3N3clJpRGwrdFNzZVpmR3ZtR2ZRPQ==;MzQwNDY0MkAzMjMwMmUzNDJlMzBURXdWT25aZU1MVHpWR1ViT2VxdlBhcUpqNzlPWFlhZ21BRTlEUzZ0K0xrPQ==;MzQwNDY0M0AzMjMwMmUzNDJlMzBKcVp0VWgzZjN4SG8xMEtBa0JBSnZhWTdPaWdublo4NFN3eWVmUnQ1OHl3PQ====;Mgo DSMBaFt/QHRqVVhkVFpHaV1LQmFJfFBmRGFTfVp6d1VWACFaRnZdQV1gS3xSdEdnWn9YcXVU;Mgo DSMBMAY9C3t2VVhkQlFacldJXnxLd0x0RWFab19yfldCal9RVBYiSV9jS31TdUdhWH1cdHdVQGVbUA==;Mgo DSMBPh8sVXJ0S0J XE9AflRBQmFAYVF2R2BJflx6dlFMY1xBJAtUQF1hSn5QdEdiW31ac3RTQWRd;MTQwOTk1OEAzMjMwMmUzNDJlMzBpb0lUbHZjNGVXRFN3bjBnTnd4S1dDOXNHKzBzcC9mem56Y1BKSE9yWi9vPQ==;NRAiBiAaIQQuGjN/V0Z WE9EaFtKVmBWfFppR2NbfE5xdl9EZFZSRGY/P1ZhSXxQdkZhW35ccnBWRmddVUU=;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxLd0x0RWFab19yfldCal9RVBYiSV9jS31TdUdhWH1cdHdVQWNcUA==;MTQwOTk2MUAzMjMwMmUzNDJlMzBKT1AvcXVmL21CekV4Ykpvc0VXMitMY29Jd0ZEOEMvY005bDlUTER3RXFzPQ==;MTQwOTk2MkAzMjMwMmUzNDJlMzBmOWQyeU42N3FqSy9FbExha21KQ3haSUhDNUV6SEw5WlZNOWZlZVRMSkswPQ==;MTQwOTk2M0AzMjMwMmUzNDJlMzBXSGtoNHAyQWlZY2hrZTBrQ3ZmR3lRVGhjWmhsVHpnSWpqQXBKR3p3YTRVPQ==;MTQwOTk2NEAzMjMwMmUzNDJlMzBDa0RLS1Jzd2t4VzJxbTI1VHUrMU1Vclg5ZWQ4VGZBOVJMTnBLUUg5V1NRPQ==;MTQwOTk2NUAzMjMwMmUzNDJlMzBDTkU1NDRQUWdxajRiUEYraU0zRlNrRDdqajJ6ZEF3MjhjeStsbzVVOXZVPQ==");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
