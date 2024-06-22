import { Component } from "@angular/core";
import { ApiService } from "./api.service";

@Component({
    selector: 'question',
    templateUrl:  './question.component.html',
    
})

export class QuestionComponent {

    question = {
        questiontxt:"",
        answertxt:"",
        wrong1:"",
        wrong2:"",
        wrong3:"",
    }

    

    constructor(private api:ApiService) {}

    post(question:any) {
        this.api.postQuestion(question)
    }

}