 CORS kullanımında UseMvc den önce kullanılması gerekiyor.           
            app.UseCors("AllowMyOrigin");
            app.UseMvc();
