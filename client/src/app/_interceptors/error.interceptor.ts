import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { catchError, Observable } from 'rxjs';
import { NavigationExtras, Router } from '@angular/router';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router: Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse)=>{
        if(error){
          switch(error.status){
            case 400:
              if(error.error.errors){
                const modalStateErros = [];
                for(const key in error.error.errors){
                  if(error.error.errors[key]){
                    modalStateErros.push(error.error.errors[key])
                  }
                }

                throw modalStateErros;
              }
            case 404:
              this.router.navigateByUrl('/not-found');
              break;
            case 500:
              const navigationExtras: NavigationExtras = {state: { error: error.error}};
              this.router.navigateByUrl('/server-error', navigationExtras);
            default:
              console.log('something unexpected went wrong');
              break;
          }
        }
        throw error;
      })
    )
      
  }
}
