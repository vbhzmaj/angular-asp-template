import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class ApiService {

    constructor(private http: HttpClient) {}

    getQuestions() {
        return this.http.get('https://localhost:44377/api/questions', {headers : new HttpHeaders({ 'Content-Type': 'application/json' })})
        }
    

    postQuestion(question:any) {
        this.http.post('https://localhost:44377/api/questions', question, {headers : new HttpHeaders({ 'Content-Type': 'application/json' })}).subscribe(res => {
            console.log(res)
        })
    }

}