import { ECommerceTemplatePage } from './app.po';

describe('ECommerce App', function() {
  let page: ECommerceTemplatePage;

  beforeEach(() => {
    page = new ECommerceTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
