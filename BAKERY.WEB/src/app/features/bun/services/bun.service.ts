import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { API_URL } from "src/environments/environment";
import { Bun } from "../models/bun.model";

@Injectable({providedIn: 'any'})
export class BunService
{
    private baseUrl = `${API_URL}/buns`;
    public constructor(private http:HttpClient) {}

    public getAll() : Observable<Bun[]>
    {
        return this.http.get<Bun[]>(this.baseUrl);
    }

    public generateRandomBunsByCount(count:number)
    {
        return this.http.post<number>(`${this.baseUrl}/generate-random`, { count });
    }
}