import { Injectable } from '@angular/core';
import { SwalService } from './swal.service';
import { TranslateService } from '@ngx-translate/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {

  constructor(private swal: SwalService,
    private translate: TranslateService,
    private router: Router) { }

  errorHandler(err: HttpErrorResponse) {
    console.log(err);

    switch (err.status) {
      case 0:
        this.translate.get("apiNotAvailable").subscribe(res => {
          this.swal.callToast(res, "error");
          //sayfa devamlı yenileme yaparsa bu koddan kaynaklı
          document.location.href = "/maintenance";  
        });
        break;

      case 400:
        this.swal.callToast(err.error.message, "error");
        break;

      case 404:
        this.translate.get("apiNotFound").subscribe(res => {
          this.swal.callToast(res, "error");
        });
        break;

      case 400:
        this.swal.callToast(err.error.message, "error");
        break;

      default:
        this.translate.get("errorStatusNotFound").subscribe(res => {
          this.swal.callToast(res, "error");
        });
        break;

    }
  }
}
