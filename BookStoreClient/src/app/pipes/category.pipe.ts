import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'category',
    standalone: true
})
export class CategoryPipe implements PipeTransform {

  transform(value: any[], search: string) {
    if(search === "") return value; //Boş ise original değeri gönder

    return value.filter(p => p.name.toLowerCase().includes(search.toLowerCase()));
  }

}
