
export default class ProductService {
  static get entity () {
    return 'cheese'
  }

    async GetCheese (params = {}, data = {}) {
      // Default options are marked with *
        try {
            const response = await fetch(`/api/cheese`, {
                method: "GET",
                mode: "cors", 
                cache: "no-cache",
                credentials: "same-origin", 
                headers: {
                "Content-Type": "application/json",
                },
                redirect: "follow",
                referrerPolicy: "no-referrer", 
            });
            return response.json(); 
        } catch(ex) {
            console.error("Error loading cheese", ex)
        }
    }
}